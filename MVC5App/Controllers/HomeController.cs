using Microsoft.ApplicationInsights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var ai = new TelemetryClient();
            ai.TrackEvent("首頁", new Dictionary<string, string>
            {
                { "負責人", "Will 保哥" },
                { "執行時間", DateTime.Now.ToString() }
            });
            return View();
        }

        public ActionResult About(int id)
        {
            ViewBag.Message = System.Web.Configuration.WebConfigurationManager.AppSettings["test"];

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}