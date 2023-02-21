﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sf376_Mission6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sf376_Mission6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext MovieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext name)
        {
            _logger = logger;
            MovieContext = name;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieEntryForm()
        {
            ViewBag.Catergories = MovieContext.Catergories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult MovieEntryForm(ApplicationResponse ar)
        {
            MovieContext.Add(ar);
            MovieContext.SaveChanges();

            return View("Confirmation",ar);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var movies = MovieContext.responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title).ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(string title)
        {
            ViewBag.Catergories = MovieContext.Catergories.ToList();

            var movie = MovieContext.responses.Single(x => x.Title == title);

            return View("MovieEntryForm", movie);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse blah)
        {
            MovieContext.Update(blah);
            MovieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(string title)
        {
            var movie = MovieContext.responses.Single(x => x.Title == title);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            MovieContext.responses.Remove(ar);
            MovieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
    }
}
