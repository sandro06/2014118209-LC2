using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2014118209_ENT.Entities;
using _2014118209_PER;

namespace _2014118209.MVC.Controllers
{
    public class TripulacionesController : Controller
    {
        private _2014118209DbContext db = new _2014118209DbContext();

        // GET: Tripulaciones
        public ActionResult Index()
        {
            var tripulaciones = db.Tripulaciones.Include(t => t.Bus);
            return View(tripulaciones.ToList());
        }

        // GET: Tripulaciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tripulacion tripulacion = db.Tripulaciones.Find(id);
            if (tripulacion == null)
            {
                return HttpNotFound();
            }
            return View(tripulacion);
        }

        // GET: Tripulaciones/Create
        public ActionResult Create()
        {
            ViewBag.BusId = new SelectList(db.Buses, "BusId", "Placa");
            return View();
        }

        // POST: Tripulaciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpleadoId,Dni,Nombres,Apellidos,BusId,TipoTripulacion")] Tripulacion tripulacion)
        {
            if (ModelState.IsValid)
            {
                db.Tripulaciones.Add(tripulacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BusId = new SelectList(db.Buses, "BusId", "Placa", tripulacion.BusId);
            return View(tripulacion);
        }

        // GET: Tripulaciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tripulacion tripulacion = db.Tripulaciones.Find(id);
            if (tripulacion == null)
            {
                return HttpNotFound();
            }
            ViewBag.BusId = new SelectList(db.Buses, "BusId", "Placa", tripulacion.BusId);
            return View(tripulacion);
        }

        // POST: Tripulaciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpleadoId,Dni,Nombres,Apellidos,BusId,TipoTripulacion")] Tripulacion tripulacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tripulacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BusId = new SelectList(db.Buses, "BusId", "Placa", tripulacion.BusId);
            return View(tripulacion);
        }

        // GET: Tripulaciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tripulacion tripulacion = db.Tripulaciones.Find(id);
            if (tripulacion == null)
            {
                return HttpNotFound();
            }
            return View(tripulacion);
        }

        // POST: Tripulaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tripulacion tripulacion = db.Tripulaciones.Find(id);
            db.Tripulaciones.Remove(tripulacion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
