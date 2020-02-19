using HarshavardhanEntityFrameworkDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HarshavardhanEntityFrameworkDB.Controllers
{
    public class ProductsController : Controller
    {
        EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();

        // GET: Products
        public ActionResult Index(string search = "")
        {
            ViewBag.Search = search;
            List<Product> products = db.Products.Where(t => t.ProductName.Contains(search)).ToList();
            return View(products);
        }

        public ActionResult Details( long id)
        {
            Product P = db.Products.Where(t => t.ProductID == id).FirstOrDefault();
            return View(P);

        }

        public ActionResult Create()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Create(Product p)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();

            db.Products.Add(p);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}