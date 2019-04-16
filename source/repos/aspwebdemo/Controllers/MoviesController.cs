using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aspwebdemo.Models;
using aspwebdemo.ViewModel;

namespace aspwebdemo.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
       public ActionResult Random()     
        {
            var movies = new Movies() { Name = "Panja" };
            var customers = new List<Customer>
            {
                new Customer{Name="Customer 1"},
                new Customer{Name="Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                movies = movies,
                Customers = customers
            };
            return View(viewModel);
        }
 
    }
}