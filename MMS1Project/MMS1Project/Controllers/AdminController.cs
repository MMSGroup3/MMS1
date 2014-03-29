using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MMS1Project.Models;
using System.Data.Objects;

namespace MMS1Project.Controllers
{
    public class AdminController : Controller
    {
        private AdminDBContext db = new AdminDBContext();

        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View(db.Admin1s.ToList());
        }

        //
        // GET: /Admin/Details/5

        public ActionResult Details(int id = 0)
        {
            Admin1 admin1 = db.Admin1s.Find(id);
            if (admin1 == null)
            {
                return HttpNotFound();
            }
            return View(admin1);
        }

        //
        // GET: /Admin/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Admin1 admin)
        {
            if (ModelState.IsValid)
            {
                db.Admin1s.Add(admin);
                
                try
                {
                db.SaveChanges();
                }
                catch(Exception ex)
                {
                    string s = ex.Message;
                }
                //catch(OptimisticConcurrencyException)
                //{
                    
                //}
                return RedirectToAction("Index");
            }

            return View(admin);
        }

        //
        // GET: /Admin/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Admin1 admin = db.Admin1s.Find(id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        //
        // POST: /Admin/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Admin1 admin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(admin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(admin);
        }

        //
        // GET: /Admin/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Admin1 admin = db.Admin1s.Find(id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        //
        // POST: /Admin/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Admin1 admin = db.Admin1s.Find(id);
            db.Admin1s.Remove(admin);
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