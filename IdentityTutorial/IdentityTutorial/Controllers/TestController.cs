using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentityTutorial.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        // Add an Identity to test .....................
        [Authorize]
        public ActionResult Index()
        {
            return Content("We are using Identity");
        }


        // No Identity example
        public ActionResult NoIdentity()
        {
            return Content(" No Identity here....");
        }
    }
}