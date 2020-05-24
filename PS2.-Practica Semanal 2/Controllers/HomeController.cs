using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PS2._Practica_Semanal_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("ViewProfile", "Users");
            }
          
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
        public ActionResult Capuchino()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult CafeAmericanp()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult CafeconLeche()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Bombon()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Expresso()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Frappe()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Mocca()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}