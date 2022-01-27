using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission04.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private MovieFormContext blahContext { get; set; }

        //Constructor
        public HomeController(ILogger<HomeController> logger, MovieFormContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }
        // this takes you to the My Podcasts page
        public IActionResult MyPodcasts()
        {
            return View();
        }

        // this sends you to the form view
        [HttpGet]
        public IActionResult MovieForm ()
        {
            return View();
        }

        // this saves the filled out form to the database
        [HttpPost]
        public IActionResult MovieForm(FormResponse fr)
        {
            blahContext.Add(fr);
            blahContext.SaveChanges();
            return View("FormConfirmation", fr);
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
