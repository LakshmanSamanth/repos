using AspDotNetMVCfromDotNetTutorialDotNetLakshman.Models;
using AspDotNetMVCfromDotNetTutorialDotNetLakshman.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspDotNetMVCfromDotNetTutorialDotNetLakshman.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            EmployeeBusinessLayer empBL = new EmployeeBusinessLayer();
            Employee emp = empBL.GetDetailsById(102);

            // Here we pass data with ViewData from controller action method to View.....
            // View Data implements IDictionary Interface....
            // we pass using KeyValuePairs(string) and Value in ObjectType....
            // ViewData requires typecasting,

            ViewData["Employee"] = emp;
            ViewData["Header"] = "Employee Details";

            return View();
        }

        public ActionResult EmployeeDetails()
        {
            EmployeeBusinessLayer empBL = new EmployeeBusinessLayer();
            Employee emp = empBL.GetDetailsById(102);

            //Using ViewBag we need not typecast.....

            ViewBag.Employee = emp;
            ViewBag.Header = "Employee Details...";

            return View();

        }

        public ActionResult Employee()
        {

            EmployeeBusinessLayer empBL = new EmployeeBusinessLayer();
            Employee emp = empBL.GetDetailsById(102);

            ViewBag.Header = "Employee Details";
            return View(emp);
        }


        public ViewResult Details()
        {
            Student student = new Student()
            {
                StudentId = 101,
                Name = "Sai Ram Sagar",
                Department = "Computer Science Engineering",
                Gender = "Male",
                AddressId = 1001,
                Salary = 50000
            };

            Address address = new Address()
            {
                AddressId = 1001,
                State = "AP",
                City = "Visakhapatnam",
                Country = "India",
                Pin = "530013"
            };

            StudentDetailsViewModel sdvm = new StudentDetailsViewModel()
            {
                Student = student,
                Address = address,
                PageHeader = "Student details Page",
                PageTitle = "Student details"


            };

            return View(sdvm);
        }


        // TempData example.....................
        public ActionResult MethodOne()
        {
            TempData["Name"] = "Lakshman Samanth Reddy";
            TempData["Age"] = 27;

            return View();
        }

        public ActionResult MethodTwo()
        {
            string UserName;
            int UserAge;

            if(TempData.ContainsKey("Name"))
            {

                UserName = TempData["Name"].ToString();
            }

            if (TempData.ContainsKey("Age"))
            {
                UserAge = int.Parse(TempData["Age"].ToString());
            }

            TempData.Keep();


            return View();
        }
    }
}