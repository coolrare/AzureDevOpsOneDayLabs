using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCore21.Models;
using Microsoft.ApplicationInsights;

namespace AspNetCore21.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var ai = new TelemetryClient();
            ai.TrackEvent("Core Home", new Dictionary<string, string>
            {
                { "Author", "Will 保哥" },
                { "Duration", DateTime.Now.ToString() }
            });

            return View();
        }

        public IActionResult About(int id)
        {
            ViewData["Message"] = "Your application description page.";

            if (id == 1)
            {
                throw new ArgumentException("BAD");
            }
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
