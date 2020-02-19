using HarshavardhanEntityFrameworkDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace HarshavardhanEntityFrameworkDB.Controllers
{
    public class CategoriesController : Controller
    {
        EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();

        // GET: Categories
        public ActionResult Index()
        {
            List<Category> categories = db.Categories.ToList();

            return View(categories);
        }
    }
}