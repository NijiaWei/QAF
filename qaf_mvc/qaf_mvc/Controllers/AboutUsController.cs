using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using qaf_mvc.Models;

namespace qaf_mvc.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly SiteData _siteData;
        public AboutUsController(SiteData siteData)
        {
            _siteData = siteData;
        }
        public IActionResult Index()
        {
            return View(_siteData);
        }
    }
}
