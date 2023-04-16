using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Seesion1.Models;
using Seesion1.Data;
using Seesion1.Security;

namespace Seesion1.Controllers
{
    public class AccountsController : Controller
    {
        private DBContext db = new DBContext();

        // GET: Accountsp
        public PartialViewResult GetUser(int page=1,int pageSize = 5)
        {
            var user = new User();
            var model = user.ListUser(page, pageSize);
            return PartialView(model);
        }
        public ActionResult ListUser(int page = 1, int pageSize = 5,string searchTerm = "")
        {
            
            var user = new User();
           
            var model = user.ListUser(page, pageSize);
            if (!String.IsNullOrEmpty(searchTerm))
            {
                model = model.Where(x => x.name.Contains(searchTerm));
            }
            if (Request.IsAjaxRequest())
            { return PartialView("GetUser", model); }
           
             return View(model);
        }
       
        public ActionResult Index()
        {
            var User = db.Accounts.Where(p=>p.rol== false).ToList();
            /*var User = db.Accounts.ToList();
           
            return Request.IsAjaxRequest()
                ? (ActionResult)PartialView("List", User)
                : View(User);*/
            return View(User);

        }
        public ActionResult GetList()
        {
            var acc = db.Accounts.Where(p=>p.rol == false);
            return Json(new { data = acc }, JsonRequestBehavior.AllowGet);
        }

        /*public PartialViewResult List(string search,int?page)
        {
            var User = db.Accounts.Where(p=>p.rol == false);
            if (!String.IsNullOrEmpty(search))
            {
                User = User.Where(x => x.name.Contains(search));
            }
            int pagesize = 3;
            int pagenumber = (page ?? 1);
            return PartialView(User.OrderBy(p=>p.name).ToPagedList(pagenumber, pagesize));
            
        }*/
        // GET: Accounts/Details/5
        
        // GET: Accounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,username,password,name,rol")] Account account)
        {
            if (ModelState.IsValid)
            {
                db.Accounts.Add(account);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(account);
        }

        // GET: Accounts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Account account = db.Accounts.Find(id);
            if (account == null)
            {
                return HttpNotFound();
            }
            return View(account);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,username,password,name,rol")] Account account)
        {
            if (ModelState.IsValid)
            {
                db.Entry(account).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(account);
        }

        // GET: Accounts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Account account = db.Accounts.Find(id);
            if (account == null)
            {
                return HttpNotFound();
            }
            return View(account);
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Account account = db.Accounts.Find(id);
            db.Accounts.Remove(account);
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
