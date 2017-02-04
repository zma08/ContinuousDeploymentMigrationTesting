using ContinuousMigration.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContinuousMigration.Controllers
{
    public class HomeController : Controller
    {
        ZmaContext db = new ZmaContext();
        public ActionResult Index()
        {
            ViewBag.Message = ConfigurationManager.ConnectionStrings["ZmaContext"].ConnectionString;
            return View(db.Students.ToList());
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
    }
}