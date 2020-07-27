 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab22.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab22.Controllers
{
    public class MoviesController : Controller
    {
        private List<MoviesModel> _moviesList { get; set; }

        public MoviesController()
        {
            _moviesList = new List<MoviesModel>
            {
                new MoviesModel("Superman", Genre.Action),
                new MoviesModel("Spiderman", Genre.Action),
                new MoviesModel("Superbad", Genre.Comedy),
                new MoviesModel("Bad Cop", Genre.Comedy),
                new MoviesModel("Idiocracy", Genre.Comedy),
                new MoviesModel("IT", Genre.Horror),
                new MoviesModel("WALL-E", Genre.Drama),
                new MoviesModel("Shawshank Redemption", Genre.Horror),
                new MoviesModel("1917", Genre.Drama),
                new MoviesModel("Joker", Genre.Drama),
                new MoviesModel("Extraction", Genre.Action),
                new MoviesModel("Jumanji", Genre.Comedy),
                new MoviesModel("The Hangover", Genre.Comedy),
                new MoviesModel("Incidious", Genre.Horror),
                new MoviesModel("Midway", Genre.Drama)
            };

        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SearchResultTitle(MoviesModel movie)
        {
            if (!ModelState.IsValid)
                return View("Index");

            var model = new List<MoviesModel>();

            foreach (var item in _moviesList)
            {
                if (item.Title.ToLower() == movie.Title.ToLower())
                {
                    model.Add(item);
                }
            }

            return View("SearchResults", model);
        }
        [HttpPost]
        public IActionResult SearchResultGenre(MoviesModel movie)
        { 

            var model = new List<MoviesModel>();

            foreach(var item in _moviesList)
            {
                if (item.Genre == movie.Genre)
                {
                    model.Add(item);
                }
            }   
            return View("SearchResults", model);
        }
    }
}
