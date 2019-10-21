using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MIS4200Team4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Recognize your Peers";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Centric Consulting";

            return View();
        }
    }
}