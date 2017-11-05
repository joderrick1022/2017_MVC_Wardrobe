using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2017_MVC_Wardrobe.Models;

namespace _2017_MVC_Wardrobe.Controllers
{
    public class Categorty_TypeController : Controller
    {
        private Wardrobe2017Entities db = new Wardrobe2017Entities();

        // GET: Categorty_Type
        public ActionResult Index()
        {
            return View(db.Categorty_Type.ToList());
        }

        // GET: Categorty_Type/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categorty_Type categorty_Type = db.Categorty_Type.Find(id);
            if (categorty_Type == null)
            {
                return HttpNotFound();
            }
            return View(categorty_Type);
        }

        // GET: Categorty_Type/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categorty_Type/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TypeId,Categories")] Categorty_Type categorty_Type)
        {
            if (ModelState.IsValid)
            {
                db.Categorty_Type.Add(categorty_Type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categorty_Type);
        }

        // GET: Categorty_Type/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categorty_Type categorty_Type = db.Categorty_Type.Find(id);
            if (categorty_Type == null)
            {
                return HttpNotFound();
            }
            return View(categorty_Type);
        }

        // POST: Categorty_Type/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TypeId,Categories")] Categorty_Type categorty_Type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categorty_Type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categorty_Type);
        }

        // GET: Categorty_Type/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categorty_Type categorty_Type = db.Categorty_Type.Find(id);
            if (categorty_Type == null)
            {
                return HttpNotFound();
            }
            return View(categorty_Type);
        }

        // POST: Categorty_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Categorty_Type categorty_Type = db.Categorty_Type.Find(id);
            db.Categorty_Type.Remove(categorty_Type);
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
