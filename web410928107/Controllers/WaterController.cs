using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web410928107.Controllers
{
    public class WaterController : Controller
    {
        // GET: Terry
        public ActionResult Index(string name,float? w)
        {
            ViewBag.name = name;
            ViewBag.result = w*300+"cc";
            return View();
        }

    }
}