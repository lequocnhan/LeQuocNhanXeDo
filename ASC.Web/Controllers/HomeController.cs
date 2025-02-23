using ASC.Solution.Configuration;
using ASC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace ASC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IOptions<ApplicationSettings> _settings;
        public HomeController( ILogger<HomeController> logger, IOptions<ApplicationSettings> settings)
        {
           _logger =logger;
            _settings=settings;
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index()
        {
            ViewBag.Title= _settings.Value.ApplicationTitle;
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
