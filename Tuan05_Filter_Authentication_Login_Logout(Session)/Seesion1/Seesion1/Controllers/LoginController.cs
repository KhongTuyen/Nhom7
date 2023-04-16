using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Seesion1.Models;
using Seesion1.Security;

namespace Seesion1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
      public  DBContext db = new DBContext();
        
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        /*public ActionResult Index2()
        {
            var per = db.Person.ToList();
            return View(per);
        }*/
       
        public ActionResult Login(string username, string password)
        {
            var acc = db.Accounts.Where(p => p.username == username && p.password == password).FirstOrDefault();

            if(acc== null || acc.rol== false)
            {
                ViewBag.alert = "-Isvalid username or password !";
                return View("Index");
            }
            else
            {
                Session["admin"] = acc.name;
                return RedirectToAction("Index", "Home");
            }
        }
        public ActionResult Logout()
        {
            Session["admin"] = null;
            return RedirectToAction("Index", "Login");
        }
        
        /*public ActionResult Register()
        {
                  
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Person person, string email)
        {
            var p = db.Person.Where(a=>a.Email == email).FirstOrDefault();
            if (ModelState.IsValid)
            {
               if(p != null){
                    ViewBag.erorr = "Email was Exist!";
                    return View("Register");
                }

                    db.Person.Add(person);
                    db.SaveChanges();
               

                return RedirectToAction("Index");
            }

            return View(person);
        }*/
      
    }
}