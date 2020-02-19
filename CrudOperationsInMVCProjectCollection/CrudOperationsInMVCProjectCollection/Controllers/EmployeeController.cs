using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudOperationsInMVCProjectCollection.Models;

namespace CrudOperationsInMVCProjectCollection.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            using (NORTHWNDEntities context = new NORTHWNDEntities())
            {
                List<Employee> empList = context.Employees.ToList<Employee>();
                return Json(new { data = empList }, JsonRequestBehavior.AllowGet);


            }

       
        }



    }
}