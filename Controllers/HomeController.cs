using System;
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
                return RedirectToAction("AddMovie");
            }
            else
            { 
                return View();
            }
        }



        // Edits the movie in the database on the post
        [HttpPost]
        public IActionResult editMovieForm(int movieID)
        {
            Movie mov = context.Movies.Find(movieID);
            return View(mov);
        }

        //post method for editing the movie
        [HttpPost]
        public IActionResult editMovie(Movie mov)
        {
            Movie OldMov = context.Movies.Find(mov.MovieId);
            context.Movies.Remove(OldMov);
            context.Movies.Add(mov);
            context.SaveChanges();
            return RedirectToAction("ViewMovies");
        }




        // Deletes movie from the database
        [HttpPost]
        public IActionResult DeleteMovie(int movieId)
        {
            Movie movie = context.Movies.Single(m => m.MovieId == movieId);
            context.Movies.Remove(movie);
            context.SaveChanges();
            return RedirectToAction("ViewMovies");
        }

        public IActionResult ViewMovies()
        {
           // return View(context.Movies); //pass in what's stored in the db
            return View(context.Movies.Where(m => m.Title.ToLower() != "independence day"));
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
