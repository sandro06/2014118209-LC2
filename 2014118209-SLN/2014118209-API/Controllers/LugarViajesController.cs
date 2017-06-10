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
    public class LugarViajesController : ApiController
    {
        private Transportes_SandroEntities1 db = new Transportes_SandroEntities1();

        // GET: api/LugarViajes
        public IQueryable<LugarViajes> GetLugarViajes()
        {
            return db.LugarViajes;
        }

        // GET: api/LugarViajes/5
        [ResponseType(typeof(LugarViajes))]
        public IHttpActionResult GetLugarViajes(int id)
        {
            LugarViajes lugarViajes = db.LugarViajes.Find(id);
            if (lugarViajes == null)
            {
                return NotFound();
            }

            return Ok(lugarViajes);
        }

        // PUT: api/LugarViajes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLugarViajes(int id, LugarViajes lugarViajes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lugarViajes.LugarViajeId)
            {
                return BadRequest();
            }

            db.Entry(lugarViajes).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LugarViajesExists(id))
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

        // POST: api/LugarViajes
        [ResponseType(typeof(LugarViajes))]
        public IHttpActionResult PostLugarViajes(LugarViajes lugarViajes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LugarViajes.Add(lugarViajes);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = lugarViajes.LugarViajeId }, lugarViajes);
        }

        // DELETE: api/LugarViajes/5
        [ResponseType(typeof(LugarViajes))]
        public IHttpActionResult DeleteLugarViajes(int id)
        {
            LugarViajes lugarViajes = db.LugarViajes.Find(id);
            if (lugarViajes == null)
            {
                return NotFound();
            }

            db.LugarViajes.Remove(lugarViajes);
            db.SaveChanges();

            return Ok(lugarViajes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LugarViajesExists(int id)
        {
            return db.LugarViajes.Count(e => e.LugarViajeId == id) > 0;
        }
    }
}