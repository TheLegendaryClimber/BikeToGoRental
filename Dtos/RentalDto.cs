using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikeToGoRental.Dtos
{
    public class RentalDto
    {
        public byte Id { get; set; }
        public int CustomerId { get; set; }
        public List<int> BikeIds { get; set; }
    }
}