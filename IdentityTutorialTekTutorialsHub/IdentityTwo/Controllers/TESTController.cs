using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentityTwo.Controllers
{
    public class TESTController : Controller
    {
        // GET: TEST
        public ActionResult Index()
        {
            return View();
        }

        // GET: Test  
        [Authorize]
        public ActionResult Identity()
        {
            return Content("We are using Identity");
        }
        public ActionResult NonIdentiy()
        {
            return Content("We are not using Identity");
        }
    }
}