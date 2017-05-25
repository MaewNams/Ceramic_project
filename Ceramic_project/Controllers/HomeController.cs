using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seramic_project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Product()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProductDetail()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProductSet()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProductSetDetail()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult ProductNews()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ActivitiNews()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult NewsDetail()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}