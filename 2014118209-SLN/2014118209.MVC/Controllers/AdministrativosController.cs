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
    public class AdministrativosController : Controller
    {
        private _2014118209DbContext db = new _2014118209DbContext();

        // GET: Administrativos
        public ActionResult Index()
        {
            return View(db.Empleados.ToList());
        }

        // GET: Administrativos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrativo administrativo = db.Administrativos.Find(id);
            if (administrativo == null)
            {
                return HttpNotFound();
            }
            return View(administrativo);
        }

        // GET: Administrativos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrativos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpleadoId,Dni,Nombres,Apellidos,Area,Cargo")] Administrativo administrativo)
        {
            if (ModelState.IsValid)
            {
                db.Empleados.Add(administrativo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(administrativo);
        }

        // GET: Administrativos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrativo administrativo = db.Administrativos.Find(id);
            if (administrativo == null)
            {
                return HttpNotFound();
            }
            return View(administrativo);
        }

        // POST: Administrativos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpleadoId,Dni,Nombres,Apellidos,Area,Cargo")] Administrativo administrativo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(administrativo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administrativo);
        }

        // GET: Administrativos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrativo administrativo = db.Administrativos.Find(id);
            if (administrativo == null)
            {
                return HttpNotFound();
            }
            return View(administrativo);
        }

        // POST: Administrativos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Administrativo administrativo = db.Administrativos.Find(id);
            db.Empleados.Remove(administrativo);
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
