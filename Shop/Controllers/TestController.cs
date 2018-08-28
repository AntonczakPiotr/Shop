using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            //return View();
            return Content("Witaj świecie!");
        }

        public ActionResult Hello(string id)
        {
            ViewBag.Name = id;
            ViewBag.Weather = "Słońce świeci bardzo mocno!";
            //return Content("Witaj, " + id);
            return View();
        }
    }
}