using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HarshaVardhanMVCPractice.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TollFree = "222-123-999";
            ViewBag.LandLine = "2738-446";
            ViewBag.Email = "lsr@gmail.com";
            return View();
        }
    }
}