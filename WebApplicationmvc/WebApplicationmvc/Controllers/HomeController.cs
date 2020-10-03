using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationmvc.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello this is MVC home controller";
        }

        public ActionResult About()
        {
            ViewBag.Message = "Hello mahesh this is about page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}