using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTicket,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = Quotatables(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTicket,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = Quotatables(insuree);
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
        public decimal Quotatables(Insuree insuree)
        {
            var ageNow = DateTime.Now.Year - Convert.ToDateTime(insuree.DateOfBirth).Year;
            var today = DateTime.Today;
            if (Convert.ToDateTime(insuree.DateOfBirth).Date > today.AddYears(-ageNow))
            {
                ageNow--;
            }
            insuree.Quote = 50.00m;
            if (ageNow < 18)
            {
                insuree.Quote += 100.00m;
            }
            if (ageNow >= 19 && ageNow <= 25) insuree.Quote += 50.00m;
            if (ageNow > 25) insuree.Quote += 25.00m;
            if (insuree.CarYear <= 2000)
            {
                insuree.Quote += 25.00m;
            }
            if (insuree.CarYear >= 2015)
            {
                insuree.Quote += 25.00m;
            }
            if (insuree.CarMake == "porche" || insuree.CarMake == "Porche" || insuree.CarMake == "PORCHE")
            {
                insuree.Quote += 25.00m;
            }
            if (insuree.CarMake == "porche" && insuree.CarModel == "911 carrera" || insuree.CarMake == "Porche" && insuree.CarModel == "911 Carrera" || insuree.CarMake == "PORCHE" && insuree.CarModel == "911 CARRERA")
            {
                insuree.Quote += 25.00m;
            }
            if (insuree.SpeedingTicket > 0)
            {
                insuree.Quote += 10.00m * insuree.SpeedingTicket;
            }
            if (insuree.DUI == true)
            {
                insuree.Quote *= 1.25m;
            }
            if (insuree.CoverageType == true)
            {
                insuree.Quote *= 1.50m;
            }

            return insuree.Quote;
        }
    }
}
