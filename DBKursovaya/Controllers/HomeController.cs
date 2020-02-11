using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBKursovaya.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Emps()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Work()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}