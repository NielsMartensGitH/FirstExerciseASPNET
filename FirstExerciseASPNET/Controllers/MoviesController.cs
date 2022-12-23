using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstExerciseASPNET.Models;
using FirstExerciseASPNET.ViewModels;

namespace FirstExerciseASPNET.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {

            List<Movie> movies = new List<Movie>
            {
                new Movie { Name="Star Wars"},
                new Movie { Name="Lord Of The Rings"}
            };

            MovieViewModel viewModel = new MovieViewModel { Movies = movies };

            return View(viewModel);
        }
    }
}