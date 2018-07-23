using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SagoSoft.ViewModel;


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

            
            EWONSEntities EWDal = new EWONSEntities();
            WebTemplateVM TemplatesVM = new WebTemplateVM();
            TemplatesVM.WebTemps = EWDal.WebTemplates.ToList();
            return View(TemplatesVM);
        }
        public ActionResult Software()
        {
           
            return View();
        }
        public ActionResult Android()
        {
            ViewBag.Message = "Our App product";

            return View();
        }
    }
}