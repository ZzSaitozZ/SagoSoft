using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SagoSoft.Controllers
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
        public ActionResult Website()
        {
            ViewBag.Message = "Our Website product";

            return View();
        }
        public ActionResult Software()
        {
            ViewBag.Message = "Our Software product";

            return View();
        }
        public ActionResult Android()
        {
            ViewBag.Message = "Our App product";

            return View();
        }
    }
}