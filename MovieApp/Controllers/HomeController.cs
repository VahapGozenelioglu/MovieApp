using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            MovieCategoryAssoc movieCategoryAssoc = new MovieCategoryAssoc();
            movieCategoryAssoc.Movies = MovieRepository.GetMovies();
            movieCategoryAssoc.Categories = CategoryRepository.GetCategories();
            return View(movieCategoryAssoc);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            MovieCategoryAssoc movieCategoryAssoc = new MovieCategoryAssoc();
            movieCategoryAssoc.Categories = CategoryRepository.GetCategories();
            movieCategoryAssoc.Movie = MovieRepository.GetMovieById(id);
            return View(movieCategoryAssoc);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}