using System.Collections.Generic;
using System.Linq;
using Lab23.Data;
using Lab23.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab23.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieContext _dbContext;

        public MoviesController(MovieContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SearchResultTitle(Movie movie)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Index");

            var model = new List<Movie>();

            var movieList = _dbContext.Movies.ToList();

            foreach (var item in movieList)
            {
                if (item.Title.ToLower() == movie.Title.ToLower())
                {
                    model.Add(item);
                }
            }

            return View("SearchResults", model);
        }

        [HttpPost]
        public IActionResult SearchResultGenre(Movie movie)
        {
            var model = new List<Movie>();

            var movieList = _dbContext.Movies.ToList();

            foreach (var item in movieList)
            {
                if (item.Genre == movie.Genre)
                {
                    model.Add(item);
                }
            }

            return View("SearchResults", model);
        }
        [HttpPost]
        public IActionResult RegisterMovie([Bind("Title", "Genre", "Runtime")] Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();

            var model = _dbContext.Movies.ToList();

            return View(model);
        }
    }
}
