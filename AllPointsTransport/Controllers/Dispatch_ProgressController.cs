using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AllPointsTransport.Models;

namespace AllPointsTransport.Controllers
{
    public class Dispatch_ProgressController : Controller
    {
        private AllPointsTransportEntities db = new AllPointsTransportEntities();

        // GET: Dispatch_Progress
        public ActionResult Index()
        {
            return View(db.vwDispatch_Progress.ToList());
        }

        // GET: Dispatch_Progress/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vwDispatch_Progress vwDispatch_Progress = db.vwDispatch_Progress.Find(id);
            if (vwDispatch_Progress == null)
            {
                return HttpNotFound();
            }
            return View(vwDispatch_Progress);
        }

        // GET: Dispatch_Progress/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dispatch_Progress/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorkOrder,RowOrder,Pro,Container1,ToDispatch,Status,leg,WorkOrderID")] vwDispatch_Progress vwDispatch_Progress)
        {
            if (ModelState.IsValid)
            {
                db.vwDispatch_Progress.Add(vwDispatch_Progress);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vwDispatch_Progress);
        }

        // GET: Dispatch_Progress/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vwDispatch_Progress vwDispatch_Progress = db.vwDispatch_Progress.Find(id);
            if (vwDispatch_Progress == null)
            {
                return HttpNotFound();
            }
            return View(vwDispatch_Progress);
        }

        // POST: Dispatch_Progress/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorkOrder,RowOrder,Pro,Container1,ToDispatch,Status,leg,WorkOrderID")] vwDispatch_Progress vwDispatch_Progress)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vwDispatch_Progress).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vwDispatch_Progress);
        }

        // GET: Dispatch_Progress/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vwDispatch_Progress vwDispatch_Progress = db.vwDispatch_Progress.Find(id);
            if (vwDispatch_Progress == null)
            {
                return HttpNotFound();
            }
            return View(vwDispatch_Progress);
        }

        // POST: Dispatch_Progress/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vwDispatch_Progress vwDispatch_Progress = db.vwDispatch_Progress.Find(id);
            db.vwDispatch_Progress.Remove(vwDispatch_Progress);
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
