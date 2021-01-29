using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using loyaltyentity.Models;

namespace loyaltyentity.Controllers
{
    public class CustomerCFController : Controller
    {
        private CustomerContextCF db = new CustomerContextCF();

        // GET: CustomerCF
        public ActionResult Index()
        {
            return View(db.CustomerCF.ToList());
        }

        // GET: CustomerCF/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerCF CustomerCF = db.CustomerCF.Find(id);
            if (CustomerCF == null)
            {
                return HttpNotFound();
            }
            return View(CustomerCF);
        }

        // GET: CustomerCF/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerCF/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,title,firstname,surname,address1,address2,address3,address4,postcode,telephone,age,Created_at,Updated_at")] CustomerCF CustomerCF)
        {
            if (ModelState.IsValid)
            {
                db.CustomerCF.Add(CustomerCF);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(CustomerCF);
        }

        // GET: CustomerCF/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerCF CustomerCF = db.CustomerCF.Find(id);
            if (CustomerCF == null)
            {
                return HttpNotFound();
            }
            return View(CustomerCF);
        }

        // POST: CustomerCF/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,title,firstname,surname,address1,address2,address3,address4,postcode,telephone,age,Created_at,Updated_at")] CustomerCF CustomerCF)
        {
            if (ModelState.IsValid)
            {
                db.Entry(CustomerCF).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(CustomerCF);
        }

        // GET: CustomerCF/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerCF CustomerCF = db.CustomerCF.Find(id);
            if (CustomerCF == null)
            {
                return HttpNotFound();
            }
            return View(CustomerCF);
        }

        // POST: CustomerCF/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomerCF CustomerCF = db.CustomerCF.Find(id);
            db.CustomerCF.Remove(CustomerCF);
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
