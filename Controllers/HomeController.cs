﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment9.Models;

namespace Assignment9.Controllers
{
    // Constructor brings in context
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MovieDbContext context { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieDbContext con)
        {
            _logger = logger;
            context = con;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                context.Movies.Add(movie);
                context.SaveChanges();
                //return View("Confirmation", movie);
            }
            return View();
        }

        public IActionResult ViewMovies()
        {
            return View(context.Movies); //pass in what's stored in the db
        }

        public IActionResult Podcast()
        {
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
