using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BikeToGoRental.Models;
using BikeToGoRental.ViewModels;


namespace BikeToGoRental.Controllers
{
    public class BikesController : Controller
    {

        // GET: Bikes
        private ApplicationDbContext _context;

        public BikesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // Adding new bike
        public ActionResult New()
        {

            var surfaceTypes = _context.SurfaceTypes.ToList();
            var viewModel = new BikeFormViewModel
            {
                Bike = new Bike(),
                SurfaceTypes = surfaceTypes

            };
            return View("BikeForm", viewModel);
        }

        // Saving new bike
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Bike bike)
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new BikeFormViewModel
                {
                    Bike = bike,
                    SurfaceTypes = _context.SurfaceTypes.ToList()

                };
                return View("BikeForm", viewModel);
            }

            if (bike.Id == 0)
                _context.Bikes.Add(bike);

            else
            {
                var bikeInDb = _context.Bikes.Single(b => b.Id == bike.Id);

                bikeInDb.Name = bike.Name;
                bikeInDb.Model = bike.Model;
                bikeInDb.Gears = bike.Gears;
                bikeInDb.FrameSize = bike.FrameSize;
                bikeInDb.SurfaceType = bike.SurfaceType;
                bikeInDb.AmountInStock = bike.AmountInStock;


            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Bikes");
        }



        // GET: Bikes and Surface Types

        public ViewResult Index()
        {
            var bikes = _context.Bikes.Include(b => b.SurfaceType).ToList();

            return View(bikes);

            
        }
        public ActionResult Details(int id)
        {
            var bike = _context.Bikes.Include(b => b.SurfaceType).SingleOrDefault(b => b.Id == id);

            if (bike == null)
                return HttpNotFound();

            return View(bike);

        }

        // Editing bikes
        public ActionResult Edit(int id)
        {
            var bike = _context.Bikes.SingleOrDefault(b => b.Id == id);
            if (bike == null)
                return HttpNotFound();
            var viewModel = new BikeFormViewModel
            {
                Bike = bike,
                SurfaceTypes = _context.SurfaceTypes.ToList()

            };
            return View("BikeForm", viewModel);

        }
   }
}