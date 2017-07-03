﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vildy.Models;
using Vildy.ViewModel;

namespace Vildy.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies

        //[Route("movies/byreleasedate/year/{year}/{month:regex(\\d{2})}:range(1, 12)")]


        public ActionResult Random()
        {
            var movie = new Movie { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer {Name="Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers                
            };



            return View(viewModel);
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + " / " + month);

        }
    }
}