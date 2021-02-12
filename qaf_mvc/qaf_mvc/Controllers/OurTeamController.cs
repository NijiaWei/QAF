using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using qaf_mvc.Models;

namespace qaf_mvc.Controllers
{
    [Route("[controller]")] //https://localhost/OurTeam
    public class OurTeamController : Controller
    {
        private readonly SiteData _siteData;
        public OurTeamController(SiteData siteData)
        {
            _siteData = siteData;
        }

        [Route("")] // https://localhost/OurTeam/""
        public IActionResult Index()
        {
            return View(_siteData);
        }

        [Route("{id}")] //https://localhost/OurTeam/{id}
        public IActionResult Member(string id)
        {
            var employee = _siteData.Employees.SingleOrDefault(x => x.Id == id);

            if (employee == null)
                return RedirectToAction("Index", "OurTeam");

            return View(employee);
        }
    }
}
