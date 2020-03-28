using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BikeToGoRental.Models;

namespace BikeToGoRental.ViewModels
{
    public class BikeFormViewModel
    {
        public IEnumerable<SurfaceType> SurfaceTypes { get; set; }
        public Bike Bike { get; set; }
    }
}
