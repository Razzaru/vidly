using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var arr = new List<Movie> { new Movie { Id = 1, Name = "Inception" }, new Movie { Id = 2, Name = "Interstellar" } };
            var movies = new MoviesViewModel { Movies = arr };
            return View(movies);
        }
    }
}