using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web410928107.Controllers
{
    public class TerryController : Controller
    {
        // GET: Terry
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HW1()
        {
            return View();
        }
        public ActionResult HW2()
        {
            return View();
        }
        public ActionResult HW3()
        {
            ViewBag.terry = "2";
            ViewData["bob"] = "20";
            return View();
        }
        public ActionResult test()
        {
            return View();
        }
    }
}