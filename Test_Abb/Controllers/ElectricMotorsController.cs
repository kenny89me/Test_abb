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
    public class ElectricMotorsController : Controller
    {
        private TestContext db = new TestContext();

        // GET: ElectricMotors
        public ActionResult Index()
        {
            var c = db.CombustionMotors
                .Where(s => s.MotorName == "Motor2")
                .FirstOrDefault<CombustionMotor>();

            //ViewBag.Message = c.ToString();

            var b = db.CombustionMotors.ToList();
            foreach (var item in b)
            {
                item.Max;
            }
            return View(db.ElectricMotors.ToList());
        }

        // GET: ElectricMotors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElectricMotor electricMotor = db.ElectricMotors.Find(id);
            if (electricMotor == null)
            {
                return HttpNotFound();
            }
            return View(electricMotor);
        }

        // GET: ElectricMotors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ElectricMotors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,VoltageV,CurrentA,MotorName,MotorType,MaxPower")] ElectricMotor electricMotor)
        {
            if (ModelState.IsValid)
            {
                db.ElectricMotors.Add(electricMotor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(electricMotor);
        }

        // GET: ElectricMotors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElectricMotor electricMotor = db.ElectricMotors.Find(id);
            if (electricMotor == null)
            {
                return HttpNotFound();
            }
            return View(electricMotor);
        }

        // POST: ElectricMotors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,VoltageV,CurrentA,MotorName,MotorType,MaxPower")] ElectricMotor electricMotor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(electricMotor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(electricMotor);
        }

        // GET: ElectricMotors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElectricMotor electricMotor = db.ElectricMotors.Find(id);
            if (electricMotor == null)
            {
                return HttpNotFound();
            }
            return View(electricMotor);
        }

        // POST: ElectricMotors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ElectricMotor electricMotor = db.ElectricMotors.Find(id);
            db.ElectricMotors.Remove(electricMotor);
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
