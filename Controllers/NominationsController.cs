using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MIS4200Team4.DAL;
using MIS4200Team4.Models;

namespace MIS4200Team4.Controllers
{
    public class NominationsController : Controller
    {
        private MIS4200Team4Context db = new MIS4200Team4Context();

        // GET: Nominations
        public ActionResult Index()
        {
            var nomination = db.Nomination.Include(n => n.UserProfile);
            return View(nomination.ToList());
        }

        // GET: Nominations/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nomination nomination = db.Nomination.Find(id);
            if (nomination == null)
            {
                return HttpNotFound();
            }
            return View(nomination);
        }

        // GET: Nominations/Create
        public ActionResult Create()
        {
            ViewBag.userID = new SelectList(db.UserProfile, "userID", "fullName");
            return View();
        }

        // POST: Nominations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RecognitionId,userID,DateOfRecognition,award")] Nomination nomination)
        {
            if (ModelState.IsValid)
            {
                //nomination.RecognitionId = Guid.NewGuid();
                db.Nomination.Add(nomination);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.userID = new SelectList(db.UserProfile, "userID", "firstName", nomination.userID);
            return View(nomination);
        }

        // GET: Nominations/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nomination nomination = db.Nomination.Find(id);
            if (nomination == null)
            {
                return HttpNotFound();
            }
            ViewBag.userID = new SelectList(db.UserProfile, "userID", "firstName", nomination.userID);
            return View(nomination);
        }

        // POST: Nominations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RecognitionId,userID,DateOfRecognition,award")] Nomination nomination)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nomination).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.userID = new SelectList(db.UserProfile, "userID", "firstName", nomination.userID);
            return View(nomination);
        }

        // GET: Nominations/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nomination nomination = db.Nomination.Find(id);
            if (nomination == null)
            {
                return HttpNotFound();
            }
            return View(nomination);
        }

        // POST: Nominations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Nomination nomination = db.Nomination.Find(id);
            db.Nomination.Remove(nomination);
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
