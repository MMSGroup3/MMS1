using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MMS1Project.Models;

namespace MMS1Project.Controllers
{
    public class MMSEventController : Controller
    {
        private MMSEventContext db = new MMSEventContext();

        //
        // GET: /MMSEvent/

        public ActionResult Index()
        {
            return View(db.MMSEvents.ToList());
        }

        //
        // GET: /MMSEvent/Details/5

        public ActionResult Details(int id = 0)
        {
            MMSEvent mmsevent = db.MMSEvents.Find(id);
            if (mmsevent == null)
            {
                return HttpNotFound();
            }
            return View(mmsevent);
        }

        //
        // GET: /MMSEvent/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MMSEvent/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MMSEvent mmsevent)
        {
            if (ModelState.IsValid)
            {
                db.MMSEvents.Add(mmsevent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mmsevent);
        }

        //
        // GET: /MMSEvent/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MMSEvent mmsevent = db.MMSEvents.Find(id);
            if (mmsevent == null)
            {
                return HttpNotFound();
            }
            return View(mmsevent);
        }

        //
        // POST: /MMSEvent/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MMSEvent mmsevent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mmsevent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mmsevent);
        }

        //
        // GET: /MMSEvent/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MMSEvent mmsevent = db.MMSEvents.Find(id);
            if (mmsevent == null)
            {
                return HttpNotFound();
            }
            return View(mmsevent);
        }

        //
        // POST: /MMSEvent/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MMSEvent mmsevent = db.MMSEvents.Find(id);
            db.MMSEvents.Remove(mmsevent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}