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
    public class MeasuresController : Controller
    {
        private TestContext db = new TestContext();

        // GET: Measures
        public ActionResult Index()
        {

            var electricMeasures = db.ElectricMeasures.Include(c => c.ElectricMotor).ToList();

            foreach (var i in electricMeasures)
            {

                i.DifferenceA = /*i.ElectricMotor.CurrentA*/ -i.ActualCurrentA;
            }
            db.SaveChanges();

            //List<ElectricMotor> CurrA = new List<ElectricMotor>();

            /*foreach (ElectricMeasure em in electricMeasures)
            {
                decimal a = em.ElectricMotor.CurrentA;
                //db.Entry(em).Collection(x => x.ElectricMotor).Load();
                em.DifferenceA = a - em.ActualCurrentA;

                /*foreach (ElectricMotor e in em.Motor)
                {
                    em.DifferenceA = (decimal)e.CurrentA - em.ActualCurrentA;

                }
                
            }*/
            //db.SaveChanges();
            return View(db.ElectricMeasures.ToList());






        }

        // GET: Measures/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Measure measure = db.Measures.Find(id);
            if (measure == null)
            {
                return HttpNotFound();
            }
            return View(measure);
        }

        // GET: Measures/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Measures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MotorType,Timestamp")] Measure measure)
        {
            if (ModelState.IsValid)
            {
                db.Measures.Add(measure);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(measure);
        }

        // GET: Measures/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Measure measure = db.Measures.Find(id);
            if (measure == null)
            {
                return HttpNotFound();
            }
            return View(measure);
        }

        // POST: Measures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MotorType,Timestamp")] Measure measure)
        {
            if (ModelState.IsValid)
            {
                db.Entry(measure).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(measure);
        }

        // GET: Measures/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Measure measure = db.Measures.Find(id);
            if (measure == null)
            {
                return HttpNotFound();
            }
            return View(measure);
        }

        // POST: Measures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Measure measure = db.Measures.Find(id);
            db.Measures.Remove(measure);
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
