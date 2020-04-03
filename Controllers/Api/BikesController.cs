using BikeToGoRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Data.Entity;

namespace BikeToGoRental.Controllers.Api
{
    public class BikesController : ApiController
    {
        private ApplicationDbContext _context;

        public BikesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET api/bikes
        public IEnumerable<Bike> GetBikes()

        {
            return _context.Bikes.Include(b => b.SurfaceType).ToList();

        }

        // GET api/bikes/1
        public Bike GetBikes(int id)
        {
            var bike = _context.Bikes.SingleOrDefault(c => c.Id == id);

            if (bike == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return bike;
        }

        // POST api/bikes

        [HttpPost]
        public Bike CreateBike(Bike bike)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Bikes.Add(bike);
            _context.SaveChanges();

            return bike;
        }

        //PUT api/bikes/1
        [HttpPut]
        public void UpdateBike(int id, Bike bike)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var bikeInDb = _context.Bikes.SingleOrDefault(c => c.Id == id);

            if (bikeInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            bikeInDb.Name = bike.Name;
            bikeInDb.Model = bike.Model;
            bikeInDb.Gears = bike.Gears;
            bikeInDb.FrameSize = bike.FrameSize;
            bikeInDb.SurfaceTypeId = bike.SurfaceTypeId;
            bikeInDb.AmountInStock = bike.AmountInStock;

            _context.SaveChanges();


        }

        //DELETE api/bikes/1 
        [HttpDelete]
        public void DeleteBike(int id)
        {
            var bikeInDb = _context.Bikes.SingleOrDefault(c => c.Id == id);

            if (bikeInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Bikes.Remove(bikeInDb);
            _context.SaveChanges();
        }

    }
}
