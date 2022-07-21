using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project3.Models;
using Project3.Models.Entity;

namespace Project3.Controllers.Entity
{
    public class LapsController : Controller
    {
        private ModelContext db = new ModelContext();

        // GET: Laps
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            var laps = db.Laps.Include(l => l.Branch);
            return View(laps.ToList());
        }

        // GET: Laps/Details/5
        [Authorize(Roles = "Admin")]        
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lap lap = db.Laps.Find(id);
            if (lap == null)
            {
                return HttpNotFound();
            }
            return View(lap);
        }

        // GET: Laps/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            ViewBag.BranchId = new SelectList(db.Branches, "BranchId", "BranchName");
            return View();
        }

        // POST: Laps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "LapId,LapName,BranchId")] Lap lap)
        {
            if (ModelState.IsValid)
            {
                db.Laps.Add(lap);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BranchId = new SelectList(db.Branches, "BranchId", "BranchName", lap.BranchId);
            return View(lap);
        }

        // GET: Laps/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lap lap = db.Laps.Find(id);
            if (lap == null)
            {
                return HttpNotFound();
            }
            ViewBag.BranchId = new SelectList(db.Branches, "BranchId", "BranchName", lap.BranchId);
            return View(lap);
        }

        // POST: Laps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "LapId,LapName,BranchId")] Lap lap)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lap).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BranchId = new SelectList(db.Branches, "BranchId", "BranchName", lap.BranchId);
            return View(lap);
        }

        // GET: Laps/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lap lap = db.Laps.Find(id);
            if (lap == null)
            {
                return HttpNotFound();
            }
            return View(lap);
        }

        // POST: Laps/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lap lap = db.Laps.Find(id);
            db.Laps.Remove(lap);
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
