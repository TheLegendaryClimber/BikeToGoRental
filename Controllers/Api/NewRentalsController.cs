using BikeToGoRental.Dtos;
using BikeToGoRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BikeToGoRental.Controllers
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController ()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {        
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
      
            var bikes = _context.Bikes.Where(b => newRental.BikeIds.Contains(b.Id)).ToList();

            foreach(var bike in bikes)
            {
                if (bike.AmountAvailable == 0)
                    return BadRequest("Bike is out of stock for now.");

                bike.AmountAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Bike = bike,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();
            return Ok();
        }
    }
}
