using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pandaloan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Pandaloan";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Pandaloan";

            return View();
        }

        public ActionResult Relogin()
        {
            ViewBag.Message = "Your relogin page.";

            return View();
        }
    }
}