using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HarshaVardhanMVCPractice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View("OurCompanyProducts");
        }

        public ActionResult GetEmpName(int EmpId)
        {
            var employees = new[] {
                new{ EmpId = 1,EmpName = "Ram",Salary = 1000},
                new{ EmpId = 2,EmpName = "Shyam",Salary = 2000},
                new{ EmpId = 3,EmpName = "Messi",Salary = 3000},
                new{ EmpId = 4,EmpName = "Philipp",Salary = 4000}

            };

            string MatchEmpName = null;
            foreach (var item in employees)
            {
                if (item.EmpId == EmpId)
                {
                    MatchEmpName = item.EmpName;
                }
            }

            return new ContentResult() { Content = MatchEmpName, ContentType = "text/plain" };
        }

        public ActionResult StudentDetails()
        {
            ViewBag.StudentId = 101;
            ViewBag.StudentName = "Ram";
            ViewBag.StudentMajors = "CSE";
            ViewBag.URL = Request.Url;
            ViewBag.PhysicalApplicationPath = Request.PhysicalApplicationPath;
            ViewBag.PhysicalPath = Request.PhysicalPath;
            ViewBag.QueryString = Request.QueryString["ram"];
            ViewBag.BrowserType = Request.Browser.Type;
            ViewBag.Header = Request.Headers["Accept"];
            ViewBag.HttpMethod = Request.HttpMethod;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TollFree = "111-123-999";
            ViewBag.LandLine = "2515766";
            ViewBag.Email = "srs@gmail.com";
            return View();
        }
    }
}