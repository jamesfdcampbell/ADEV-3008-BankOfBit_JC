using BankOfBIT_JC.Data;
using BankOfBIT_JC.Models;
using System.Data.Entity;
using System.Net;
using System.Web.Mvc;

namespace BankOfBIT_JC.Controllers
{
    public class SilverStatesController : Controller
    {
        private BankOfBIT_JCContext db = new BankOfBIT_JCContext();

        // GET: SilverStates
        public ActionResult Index()
        {
            return View(SilverState.GetInstance());
        }

        // GET: SilverStates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SilverState silverState = db.SilverStates.Find(id);
            if (silverState == null)
            {
                return HttpNotFound();
            }
            return View(silverState);
        }

        // GET: SilverStates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SilverStates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AccountStateId,LowerLimit,UpperLimit,Rate")] SilverState silverState)
        {
            if (ModelState.IsValid)
            {
                db.SilverStates.Add(silverState);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(silverState);
        }

        // GET: SilverStates/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SilverState silverState = db.SilverStates.Find(id);
            if (silverState == null)
            {
                return HttpNotFound();
            }
            return View(silverState);
        }

        // POST: SilverStates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AccountStateId,LowerLimit,UpperLimit,Rate")] SilverState silverState)
        {
            if (ModelState.IsValid)
            {
                db.Entry(silverState).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(silverState);
        }

        // GET: SilverStates/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SilverState silverState = db.SilverStates.Find(id);
            if (silverState == null)
            {
                return HttpNotFound();
            }
            return View(silverState);
        }

        // POST: SilverStates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SilverState silverState = db.SilverStates.Find(id);
            db.SilverStates.Remove(silverState);
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
