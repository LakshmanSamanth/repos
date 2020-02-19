using DataValidationsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataValidationsMVC.Controllers
{
    public class DataAnnController : Controller
    {
        // GET: DataAnn
        public ActionResult Index()
        {
            return View();
        }

        //POST: DataAnn
        [HttpPost]
        public ActionResult Index(EmpClass obj)
        {
            if (ModelState.IsValid)
                return Redirect("/DataAnn/Index");
            return View(obj);
        }
    }
}