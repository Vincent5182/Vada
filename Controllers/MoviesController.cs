using System.Collections.Generic;
using System.Web.Mvc;
using Vada.Models;
using Vada.ViewModels;

namespace Vada.Controllers
{
    public class MoviesController : Controller
    {

        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Batman" },
                new Movie { Id = 2, Name = "Superman" }
            };
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Iron Man"
            };
            var customers = new List<Customer>
            {
                new Customer {Name = "John"},
                new Customer {Name = "Jane"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers

            };

            return View(viewModel);
        }
    }
}