using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Test_Abb.DAL;
using Test_Abb.Models;

namespace Test_Abb.Controllers
{
    public class CombustionMotorsController : Controller
    {
        private TestContext db = new TestContext();

        // GET: CombustionMotors
        public ActionResult Index()
        {
            return View(db.CombustionMotors.ToList());
        }

        // GET: CombustionMotors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CombustionMotor combustionMotor = db.CombustionMotors.Find(id);
            if (combustionMotor == null)
            {
                return HttpNotFound();
            }
            return View(combustionMotor);
        }

        // GET: CombustionMotors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CombustionMotors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FuelConsumption,MaxTorque,MotorName,MotorType,MaxPower")] CombustionMotor combustionMotor)
        {
            if (ModelState.IsValid)
            {
                db.CombustionMotors.Add(combustionMotor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(combustionMotor);
        }

        // GET: CombustionMotors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CombustionMotor combustionMotor = db.CombustionMotors.Find(id);
            if (combustionMotor == null)
            {
                return HttpNotFound();
            }
            return View(combustionMotor);
        }

        // POST: CombustionMotors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FuelConsumption,MaxTorque,MotorName,MotorType,MaxPower")] CombustionMotor combustionMotor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(combustionMotor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(combustionMotor);
        }

        // GET: CombustionMotors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CombustionMotor combustionMotor = db.CombustionMotors.Find(id);
            if (combustionMotor == null)
            {
                return HttpNotFound();
            }
            return View(combustionMotor);
        }

        // POST: CombustionMotors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CombustionMotor combustionMotor = db.CombustionMotors.Find(id);
            db.CombustionMotors.Remove(combustionMotor);
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
