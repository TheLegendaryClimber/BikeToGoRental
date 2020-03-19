using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikeToGoRental.Models
{
    public class Bike
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public SurfaceType SurfaceType { get; set; }
        public byte SurfaceTypeId { get; set; }
        public string Model { get; set; }
        public string Gears { get; set; }
        public string FrameSize { get; set; }

    }
}