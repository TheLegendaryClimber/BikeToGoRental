using BikeToGoRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikeToGoRental.ViewModels
{
    public class NewRentalViewModel
    {
        
        public Customer Customer { get; set; }
        public Bike Bike { get; set; }
    }
}