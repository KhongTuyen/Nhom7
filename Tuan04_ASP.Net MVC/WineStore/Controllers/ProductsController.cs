using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WineStore.Models;
using PagedList;
namespace WineStore.Controllers
{
    public class ProductsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Products
        public ActionResult Index(string Sort, string Search,int? page)
        {
            var products = db.Products.Select(p => p);
            
            ViewBag.SortName = string.IsNullOrEmpty(Sort) ? "name_desc" : "";
            ViewBag.SortPrice = Sort == "Gia" ? "gia_desc" : "Gia";
            ViewBag.SortCategory = Sort == "ID" ? "id_desc" : "ID";
            switch (Sort)
            {
                case "name_desc":
                    products = products.OrderByDescending(x => x.ProductName);
                    break;
                case "gia_desc":
                    products = products.OrderBy(x => x.Price);
                    break;
                case "Gia":
                    products = products.OrderByDescending(x => x.Price);
                    break;
                case "ID":
                    products = products.OrderBy(x => x.CatalogyID);
                    break;
                case "id_desc":
                    products = products.OrderByDescending(x => x.CatalogyID);
                    break;
                default:     
                    products = products.OrderBy(x => x.ProductName);                
                    break;
            }
            if (!String.IsNullOrEmpty(Search))
            {
                products = products.Where(x => x.ProductName.Contains(Search));
            }
            int pagesize = 1;
            int pagenumber = (page ?? 1);

            return View(products.ToPagedList(pagenumber,pagesize));
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.CatalogyID = new SelectList(db.Catalogies, "CatalogyID", "CatalogyName");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,ProductName,Description,PurchasePrice,Price,Quantity,Vintage,CatalogyID,Image,Region")] Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    product.Image = "";
                    var f = Request.Files["ImageFile"];
                    if (f != null && f.ContentLength > 0)
                    {
                        string Filename = System.IO.Path.GetFileName(f.FileName);
                        string UploadPath = Server.MapPath("~/image/" + Filename);
                        f.SaveAs(UploadPath);
                        product.Image = Filename;
                    }
                    db.Products.Add(product);
                    db.SaveChanges();
                   
                }
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                ViewBag.Error = "Lỗi nhập dữ liệu ! " + e.Message;
                ViewBag.CatalogyID = new SelectList(db.Catalogies, "CatalogyID", "CatalogyName", product.CatalogyID);
                return View(product);
            }
           

           
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.CatalogyID = new SelectList(db.Catalogies, "CatalogyID", "CatalogyName", product.CatalogyID);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,ProductName,Description,PurchasePrice,Price,Quantity,Vintage,CatalogyID,Image,Region")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CatalogyID = new SelectList(db.Catalogies, "CatalogyID", "CatalogyName", product.CatalogyID);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
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
