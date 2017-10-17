using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reclat.MVC.Controllers
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

        public ActionResult Disposal()
        {
            return View();
        }
        public ActionResult Recycling()
        {
            return View();
        }
        public ActionResult BuyIt()
        {
            return View();
        }
        public ActionResult Helpful()
        {
            return View();
        }
        public ActionResult Kontakti()
        {
            return View();
        }
    }
}