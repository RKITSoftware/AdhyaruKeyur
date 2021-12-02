using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        //list of Movies
        public List<Movie> objMoviesDetails = new List<Movie>
        {
            new Movie{Id = 1, Name ="Sooryavanshi", Rank = 1, Distributor = "Reliance Entertainment PVR Pictures"},
            new Movie{Id = 2, Name ="Bell Bottom", Rank = 2, Distributor = "Pen Marudhar Entertainment"},
            new Movie{Id = 3, Name ="Roohi", Rank = 3, Distributor = "Jio Studios"},
            new Movie{Id = 4, Name ="Mumbai Saga", Rank = 4, Distributor = "AA Films"},

        };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Movielist()
        {
            return View(objMoviesDetails);
        }

        public ActionResult RemoveMovie(Movie objMovie)
        {
            objMoviesDetails.Remove(objMovie);
            return View(Movielist());
        }
    }
}