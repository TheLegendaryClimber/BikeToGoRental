using BikeToGoRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;


namespace BikeToGoRental.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET api/rentals
        public IEnumerable<Rental> GetRentals()

        {
            return _context.Rentals.Include(c => c.Customer)
            .Include(b => b.Bike)
            .Include(m => m.Customer.MembershipType).
            ToList();
                

        }

        // GET api/rental/1
        public Rental GetRentals(int id)
        {
            var rental = _context.Rentals.SingleOrDefault(r => r.Id == id);

            if (rental == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return rental;
        }

        // POST api/rentals

        [HttpPost]
        public Rental CreateRent(Rental rental)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Rentals.Add(rental);
            _context.SaveChanges();

            return rental;
        }

        //PUT api/rentals/1
        [HttpPut]
        public void UpdateRent(int id, Rental rental)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var rentalInDb = _context.Rentals.SingleOrDefault(r => r.Id == id);

            if (rentalInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            rentalInDb.DateRented = rental.DateRented;
            rentalInDb.DateReturned = rental.DateReturned;
            rentalInDb.Customer.Id = rental.Customer.Id;
            rentalInDb.Bike = rental.Bike;






            _context.SaveChanges();


        }

        //DELETE api/rentals/1 
        [HttpDelete]
        public void DeleteRental(int id)
        {
            var rentalInDb = _context.Rentals.SingleOrDefault(r => r.Id == id);

            if (rentalInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Rentals.Remove(rentalInDb);
            _context.SaveChanges();
        }

    }
}

