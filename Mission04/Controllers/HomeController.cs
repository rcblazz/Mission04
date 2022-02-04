using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        

        private MovieFormContext blahContext { get; set; }

        //Constructor
        public HomeController(MovieFormContext someName)
        {
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
            ViewBag.Categories = blahContext.Categories.ToList();

            return View();
        }

        // this saves the filled out form to the database
        [HttpPost]
        public IActionResult MovieForm(FormResponse fr)
        {
            if (ModelState.IsValid)
            {
                blahContext.Add(fr);
                blahContext.SaveChanges();

                return View("FormConfirmation", fr);
            }
            else //If Invalid
            {
                ViewBag.Categories = blahContext.Categories.ToList();

                return View(fr);
            }
        }

        public IActionResult MovieList ()
        {
            var movies = blahContext.responses
                .Include(x => x.Category)
                .ToList();

            return View (movies);
        }

        [HttpGet]
        public IActionResult Edit (int movieid)
        {
            ViewBag.Categories = blahContext.Categories.ToList();

            var form = blahContext.responses.Single(x => x.MovieId == movieid);

            return View("MovieForm", form);
        }

        [HttpPost]
        public IActionResult Edit (FormResponse blah)
        {
            blahContext.Update(blah);
            blahContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete (int movieid)
        {
            var form = blahContext.responses.Single(x => x.MovieId == movieid);

            return View(form);
        }

        [HttpPost]
        public IActionResult Delete (FormResponse fr)
        {
            blahContext.responses.Remove(fr);
            blahContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
