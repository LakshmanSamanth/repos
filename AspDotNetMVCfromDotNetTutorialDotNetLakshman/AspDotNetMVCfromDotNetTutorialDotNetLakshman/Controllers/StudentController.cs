using AspDotNetMVCfromDotNetTutorialDotNetLakshman.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspDotNetMVCfromDotNetTutorialDotNetLakshman.Controllers
{
    public class StudentController : Controller
    {

        static List<Student> students = new List<Student>()
        {
            new Student() {StudentId = 1,Name= "Lakshman",  Gender = "Male",     Department = "CSE", Salary =10000, AddressId = 101 },
            new Student() {StudentId = 2,Name= "SaiRam",    Gender = "Male",     Department = "ECE", Salary =20000, AddressId = 102 },
            new Student() {StudentId = 3,Name= "Gowtham",   Gender = "Male",     Department = "Mec", Salary =30000, AddressId = 103 },
            new Student() {StudentId = 4,Name= "Lahm",      Gender = "Male",     Department = "FCB", Salary =60000, AddressId = 104 },
            new Student() {StudentId = 5,Name= "Lakshmi",   Gender = "Female",   Department = "CSE", Salary =80000, AddressId = 105 },
            new Student() {StudentId = 6,Name= "Vani" ,     Gender = "Female",   Department = "CSE", Salary =90000, AddressId = 106 },
            new Student() {StudentId = 7,Name= "Rani" ,     Gender = "Female",   Department = "CSE", Salary =70000, AddressId = 107 },

        };

        [HttpGet]
        public ActionResult GetAllStudent()
        {
            return View(students);
        }

        [HttpGet]
        public ActionResult GetStudentById(int StudentId)
        {
            Student studentdetails = students.FirstOrDefault(s => s.StudentId == StudentId);
            return View(studentdetails);
        }


        [HttpGet]
        public ActionResult GetStudentCourses(int studentID)
        {
            List<string> CourseList = new List<string>();
            if (studentID == 1)
                CourseList = new List<string>() { "ASP.NET", "C#.NET", "SQL Server" };
            else if (studentID == 2)
                CourseList = new List<string>() { "ASP.NET MVC", "C#.NET", "ADO.NET" };
            else if (studentID == 3)
                CourseList = new List<string>() { "ASP.NET WEB API", "C#.NET", "Entity Framework" };
            else
                CourseList = new List<string>() { "Bootstrap", "jQuery", "AngularJs" };
            ViewBag.CourseList = CourseList;
            return View();
        }




        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
    }
}