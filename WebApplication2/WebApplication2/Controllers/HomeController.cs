using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETrading.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Welcome()
        {
            ViewBag.Title = "Welcome Page";
            return View();
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        public ActionResult Electronics()
        {
            ViewBag.Title = "Electronics";
            return View();
        }

        public ActionResult Clothing()
        {
            ViewBag.Title = "Clothing";
            return View();
        }

        public ActionResult Shoes()
        {
            ViewBag.Title = "Shoes";
            return View();
        }

        public ActionResult Admin()
        {
            ViewBag.Message = "Admin page";
            return View();
        }

        public ActionResult Customer()
        {
            ViewBag.Message = "Customer page";
            return View();
        }

        public ActionResult Vendor()
        {
            ViewBag.Message = "Vendor page";
            return View();
        }
    }
}
