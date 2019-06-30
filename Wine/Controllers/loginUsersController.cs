using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Wine.Models;

namespace Wine.Controllers
{
    public class loginUsersController : Controller
    {
        private UserSecurityModel db = new UserSecurityModel();

        // GET: loginUsers
        public ActionResult Index()
        {
            return View(db.loginUsers.ToList());
        }

        // GET: loginUsers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            loginUser loginUser = db.loginUsers.Find(id);
            if (loginUser == null)
            {
                return HttpNotFound();
            }
            return View(loginUser);
        }

        // GET: loginUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: loginUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "userID,Username,Password")] loginUser loginUser)
        {
            if (ModelState.IsValid)
            {
                db.loginUsers.Add(loginUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loginUser);
        }

        // GET: loginUsers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            loginUser loginUser = db.loginUsers.Find(id);
            if (loginUser == null)
            {
                return HttpNotFound();
            }
            return View(loginUser);
        }

        // POST: loginUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "userID,Username,Password")] loginUser loginUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loginUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loginUser);
        }

        // GET: loginUsers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            loginUser loginUser = db.loginUsers.Find(id);
            if (loginUser == null)
            {
                return HttpNotFound();
            }
            return View(loginUser);
        }

        // POST: loginUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            loginUser loginUser = db.loginUsers.Find(id);
            db.loginUsers.Remove(loginUser);
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
