using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using qaf_mvc.Models;

namespace qaf_mvc.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SiteData _siteData;

        public HomeController(ILogger<HomeController> logger, SiteData siteData)
        {
            _logger = logger;
            _siteData = siteData;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View(_siteData);
        }

        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            return RedirectToAction("Index", "Home");
        }

        [Route("404")]
        public IActionResult Page404()
        {
            return View();
        }
    }
}
