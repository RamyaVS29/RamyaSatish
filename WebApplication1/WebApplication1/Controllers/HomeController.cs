using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
         public ActionResult Electronics()
        {
            ViewBag.Title = "Electronics";
            return View("Electronics");
        }

        // Action method for Clothing category
        public ActionResult Clothing()
        {
            ViewBag.Title = "Clothing";
            return View("Clothing");
        }

        // Action method for Shoes category
        public ActionResult Shoes()
        {
            ViewBag.Title = "Shoes";
            return View("Shoes");
        }
    }
}
