using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6_waltona1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_waltona1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieFormContext blahContext { get; set; }

        // Constructor
        public HomeController(ILogger<HomeController> logger, MovieFormContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View("MovieForm");
        }

        [HttpPost]
        public IActionResult MovieForm (FormResponse response)
        {
            if(ModelState.IsValid)
            {
                blahContext.Add(response);
                blahContext.SaveChanges();
                return View("Confirmation", response);
            }
            else
            {
                return View();
            }
        }
        public IActionResult MyPodcasts()
        {
            return View("MyPodcasts");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
