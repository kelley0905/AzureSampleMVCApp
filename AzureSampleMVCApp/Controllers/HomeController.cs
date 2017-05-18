using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace AzureSampleMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Trace.WriteLine("**INFO**The home page has been loaded.");
            Trace.TraceInformation("**INFO**The home page was loaded at: " + DateTime.Now.ToString());
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            Trace.TraceError("**ERROR**About page error: " + DateTime.Now.ToString());
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}