using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HarshaVardhanMVCPractice.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login(string UserName,string Password)
        {
            if (UserName == "admin" && Password == "manager")
            {
                return RedirectToAction("Dashboard", "Admin");
            }
            else
            {
                return RedirectToAction("InvalidLogin", "Account");
            }
        }


        public ActionResult InvalidLogin()
        {
            return View();
        }
    }
}