using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using _2014118209_API.DTO;

namespace _2014118209_API.Controllers
{
    public class ServiciosController : ApiController
    {
        private Transportes_SandroEntities1 db = new Transportes_SandroEntities1();

        // GET: api/Servicios
        public IQueryable<Servicios> GetServicios()
        {
            return db.Servicios;
        }

        // GET: api/Servicios/5
        [ResponseType(typeof(Servicios))]
        public IHttpActionResult GetServicios(int id)
        {
            Servicios servicios = db.Servicios.Find(id);
            if (servicios == null)
            {
                return NotFound();
            }

            return Ok(servicios);
        }

        // PUT: api/Servicios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutServicios(int id, Servicios servicios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != servicios.ServicioId)
            {
                return BadRequest();
            }

            db.Entry(servicios).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiciosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Servicios
        [ResponseType(typeof(Servicios))]
        public IHttpActionResult PostServicios(Servicios servicios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Servicios.Add(servicios);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = servicios.ServicioId }, servicios);
        }

        // DELETE: api/Servicios/5
        [ResponseType(typeof(Servicios))]
        public IHttpActionResult DeleteServicios(int id)
        {
            Servicios servicios = db.Servicios.Find(id);
            if (servicios == null)
            {
                return NotFound();
            }

            db.Servicios.Remove(servicios);
            db.SaveChanges();

            return Ok(servicios);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ServiciosExists(int id)
        {
            return db.Servicios.Count(e => e.ServicioId == id) > 0;
        }
    }
}