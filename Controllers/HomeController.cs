using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JoelHilton1.Models;
using Microsoft.EntityFrameworkCore;

namespace JoelHilton1.Controllers
{
    public class HomeController : Controller
    {
     

        private DatabaseContext _movieContext { get; set; }
        

        public HomeController( DatabaseContext context)
        {
            _movieContext = context;
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
        public IActionResult AddMovie()
        {
            ViewBag.Ratings = _movieContext.ratings.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(AddMovieModel movie)
        {
            if (ModelState.IsValid)
            {
            _movieContext.Add(movie);
            _movieContext.SaveChanges();
            return View("Confirmation", movie);

            }
            else
            {
                ViewBag.Ratings = _movieContext.ratings.ToList();
                return View(movie);
            }
            
        }
        public IActionResult MovieList()
        {

            var movieList = _movieContext.responses
                .Include(x => x.Rating)
                .OrderBy(x => x.MovieId)
                .ToList();
            return View(movieList);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Ratings = _movieContext.ratings.ToList();
            var movie = _movieContext.responses.Single(x => x.MovieId == id);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Edit(AddMovieModel movie)
        {

            _movieContext.Update(movie);
            _movieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = _movieContext.responses.Single(x => x.MovieId == id);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(AddMovieModel movie)
        {
            _movieContext.responses.Remove(movie);
            _movieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
