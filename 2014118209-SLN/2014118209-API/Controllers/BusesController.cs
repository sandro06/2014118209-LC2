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
    public class BusesController : ApiController
    {
        private Transportes_SandroEntities1 db = new Transportes_SandroEntities1();

        // GET: api/Buses
        public IQueryable<Buses> GetBuses()
        {
            return db.Buses;
        }

        // GET: api/Buses/5
        [ResponseType(typeof(Buses))]
        public IHttpActionResult GetBuses(int id)
        {
            Buses buses = db.Buses.Find(id);
            if (buses == null)
            {
                return NotFound();
            }

            return Ok(buses);
        }

        // PUT: api/Buses/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBuses(int id, Buses buses)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != buses.BusId)
            {
                return BadRequest();
            }

            db.Entry(buses).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusesExists(id))
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

        // POST: api/Buses
        [ResponseType(typeof(Buses))]
        public IHttpActionResult PostBuses(Buses buses)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Buses.Add(buses);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = buses.BusId }, buses);
        }

        // DELETE: api/Buses/5
        [ResponseType(typeof(Buses))]
        public IHttpActionResult DeleteBuses(int id)
        {
            Buses buses = db.Buses.Find(id);
            if (buses == null)
            {
                return NotFound();
            }

            db.Buses.Remove(buses);
            db.SaveChanges();

            return Ok(buses);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BusesExists(int id)
        {
            return db.Buses.Count(e => e.BusId == id) > 0;
        }
    }
}