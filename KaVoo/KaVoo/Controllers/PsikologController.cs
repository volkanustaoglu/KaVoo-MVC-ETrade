using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KaVoo.Entity;

namespace KaVoo.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PsikologController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Product
        public ActionResult Index()
        {
            var psikologlar = db.Psikologlar.Include(p => p.Category);
            return View(psikologlar.ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Psikolog psikolog = db.Psikologlar.Find(id);
            if (psikolog == null)
            {
                return HttpNotFound();
            }
            return View(psikolog);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,Price,Stock,Image,IsHome,IsApproved,CategoryId")] Psikolog psikolog)
        {
            if (ModelState.IsValid)
            {
                db.Psikologlar.Add(psikolog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", psikolog.CategoryId);
            return View(psikolog);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Psikolog psikolog = db.Psikologlar.Find(id);
            if (psikolog == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", psikolog.CategoryId);
            return View(psikolog);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,Price,Stock,Image,IsHome,IsApproved,CategoryId")] Psikolog psikolog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(psikolog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", psikolog.CategoryId);
            return View(psikolog);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Psikolog psikolog = db.Psikologlar.Find(id);
            if (psikolog == null)
            {
                return HttpNotFound();
            }
            return View(psikolog);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Psikolog psikolog = db.Psikologlar.Find(id);
            db.Psikologlar.Remove(psikolog);
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
