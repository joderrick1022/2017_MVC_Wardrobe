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
    public class Wardrobe_ItemsController : Controller
    {
        private Wardrobe2017Entities db = new Wardrobe2017Entities();

        // GET: Wardrobe_Items
        public ActionResult Index()
        {
            var wardrobe_Items = db.Wardrobe_Items.Include(w => w.Categorty_Type);
            return View(wardrobe_Items.ToList());
        }

        // GET: Wardrobe_Items/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wardrobe_Items wardrobe_Items = db.Wardrobe_Items.Find(id);
            if (wardrobe_Items == null)
            {
                return HttpNotFound();
            }
            return View(wardrobe_Items);
        }

        // GET: Wardrobe_Items/Create
        public ActionResult Create()
        {
            ViewBag.TypeID = new SelectList(db.Categorty_Type, "TypeId", "Categories");
            return View();
        }

        // POST: Wardrobe_Items/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemID,TypeID,Name,Photo,Color,Season,Occasion")] Wardrobe_Items wardrobe_Items)
        {
            if (ModelState.IsValid)
            {
                db.Wardrobe_Items.Add(wardrobe_Items);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TypeID = new SelectList(db.Categorty_Type, "TypeId", "Categories", wardrobe_Items.TypeID);
            return View(wardrobe_Items);
        }

        // GET: Wardrobe_Items/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wardrobe_Items wardrobe_Items = db.Wardrobe_Items.Find(id);
            if (wardrobe_Items == null)
            {
                return HttpNotFound();
            }
            ViewBag.TypeID = new SelectList(db.Categorty_Type, "TypeId", "Categories", wardrobe_Items.TypeID);
            return View(wardrobe_Items);
        }

        // POST: Wardrobe_Items/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemID,TypeID,Name,Photo,Color,Season,Occasion")] Wardrobe_Items wardrobe_Items)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wardrobe_Items).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TypeID = new SelectList(db.Categorty_Type, "TypeId", "Categories", wardrobe_Items.TypeID);
            return View(wardrobe_Items);
        }

        // GET: Wardrobe_Items/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wardrobe_Items wardrobe_Items = db.Wardrobe_Items.Find(id);
            if (wardrobe_Items == null)
            {
                return HttpNotFound();
            }
            return View(wardrobe_Items);
        }

        // POST: Wardrobe_Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Wardrobe_Items wardrobe_Items = db.Wardrobe_Items.Find(id);
            db.Wardrobe_Items.Remove(wardrobe_Items);
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
