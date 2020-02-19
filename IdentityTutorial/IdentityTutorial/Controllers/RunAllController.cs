using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentityTutorial.Controllers
{
    // Controller level  Authorization as an example....
    [Authorize]
    public class RunAllController : Controller
    {
        // GET: RunAll
        // Allow Anonomous example.....
        [AllowAnonymous]
        public ActionResult Index()
        {
            return Content("Allowing Anonoymous Object here , so disallowing Authorization on purpose ");
        }


        public ActionResult Hello()
        {
            return Content(" Controller Level Authorization served here");
        }
    }
}