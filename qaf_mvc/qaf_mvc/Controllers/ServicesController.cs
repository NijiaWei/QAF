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
    public class ServicesController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SiteData _siteData;

        public ServicesController(ILogger<HomeController> logger, SiteData siteData)
        {
            _logger = logger;
            _siteData = siteData;
        }

        public IActionResult Index()
        {
            return View(_siteData);
        }

    }
}
