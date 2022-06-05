using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCtut.Controllers
{
    // home controller looks in the Home/Views folder to find the index corresponding to the method called
    public class HomeController : Controller
    {
        //Views/Home/Index
        public ActionResult Index()
        {
            return View();
        }

        //Views/Home/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //Views/Home/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}