using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BikeToGoRental.Models;


namespace BikeToGoRental.Controllers
{
    public class BikesController : Controller
    {
        private ApplicationDbContext _context;

        public BikesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
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


    }
}