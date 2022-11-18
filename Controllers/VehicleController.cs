using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class VehicleController : Controller
    {
        // GET: Vehicles
        public ActionResult Random()
        {


            var vehicles = new List<Vehicle>
            {
                new Vehicle {Brand= "BMW", Color = "Blue", Year = "2022"},
                new Vehicle {Brand = "Ferrari", Color = "Read", Year = "2022"}
            };

            var owners = new List<Owner>
            {
                new Owner { FirstName = "Donald"},
                new Owner { FirstName = "Jack" }
            };

            var viewModel = new RandomVehicleViewModel
            {
                Vehicle = vehicles,
                Owner = owners
            };

            var viewResult = new ViewResult();
            return View(viewModel);
        }

        [Route("movies/released/{year}/{month}")]

        public ActionResult Edit (int id)
        {
            return Content("id = " + id);
        }

        public ActionResult Index (int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if(string.IsNullOrWhiteSpace(sortBy))
                sortBy = "FirstName";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        public ActionResult ByReleaseDate (int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}