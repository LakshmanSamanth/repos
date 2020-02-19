using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LakshmanDemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public string demo()
        {
            return "Hello, Happy Teacher's day..";
        }
        public ActionResult Demo()
        {
            return View();

        }

        public ActionResult demo2()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        // Method OverLoading... Example..
        public string demo(string a)
        {
            return "this is a message with OverLoad..";
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}