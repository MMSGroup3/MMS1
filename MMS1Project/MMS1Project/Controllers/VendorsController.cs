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
    public class VendorsController : Controller
    {
        private VendorDBContext db = new VendorDBContext();

        //
        // GET: /Vendors/

        public ActionResult Index()
        {
            return View(db.Vendor1s.ToList());
        }

        //
        // GET: /Vendors/Details/5

        public ActionResult Details(int id = 0)
        {
            Vendor1 vendor1 = db.Vendor1s.Find(id);
            if (vendor1 == null)
            {
                return HttpNotFound();
            }
            return View(vendor1);
        }

        //
        // GET: /Vendors/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Vendors/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vendor1 vendor1)
        {
            if (ModelState.IsValid)
            {
                db.Vendor1s.Add(vendor1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vendor1);
        }

        //
        // GET: /Vendors/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Vendor1 vendor1 = db.Vendor1s.Find(id);
            if (vendor1 == null)
            {
                return HttpNotFound();
            }
            return View(vendor1);
        }

        //
        // POST: /Vendors/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Vendor1 vendor1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vendor1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vendor1);
        }

        //
        // GET: /Vendors/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Vendor1 vendor1 = db.Vendor1s.Find(id);
            if (vendor1 == null)
            {
                return HttpNotFound();
            }
            return View(vendor1);
        }

        //
        // POST: /Vendors/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vendor1 vendor1 = db.Vendor1s.Find(id);
            db.Vendor1s.Remove(vendor1);
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