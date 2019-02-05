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
    public class CombustionMeasuresController : Controller
    {
        private TestContext db = new TestContext();

        // GET: CombustionMeasures
        public ActionResult Index()
        {

            using (TestContext db = new TestContext())
            {
                //foreach (var items in db.CombustionMotors)
                    //Console.WriteLine(item.toString());

            }











                return View(db.CombustionMeasures);
        }

        // GET: CombustionMeasures/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CombustionMeasure combustionMeasure = db.CombustionMeasures.Find(id);
            if (combustionMeasure == null)
            {
                return HttpNotFound();
            }
            return View(combustionMeasure);
        }

        // GET: CombustionMeasures/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CombustionMeasures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ActualRevsRpm,DifferenceRpm,MotorType,Timestamp")] CombustionMeasure combustionMeasure)
        {
            if (ModelState.IsValid)
            {
                db.CombustionMeasures.Add(combustionMeasure);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(combustionMeasure);
        }

        // GET: CombustionMeasures/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CombustionMeasure combustionMeasure = db.CombustionMeasures.Find(id);
            if (combustionMeasure == null)
            {
                return HttpNotFound();
            }
            return View(combustionMeasure);
        }

        // POST: CombustionMeasures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ActualRevsRpm,DifferenceRpm,MotorType,Timestamp")] CombustionMeasure combustionMeasure)
        {
            if (ModelState.IsValid)
            {
                db.Entry(combustionMeasure).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(combustionMeasure);
        }

        // GET: CombustionMeasures/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CombustionMeasure combustionMeasure = db.CombustionMeasures.Find(id);
            if (combustionMeasure == null)
            {
                return HttpNotFound();
            }
            return View(combustionMeasure);
        }

        // POST: CombustionMeasures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CombustionMeasure combustionMeasure = db.CombustionMeasures.Find(id);
            db.CombustionMeasures.Remove(combustionMeasure);
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
