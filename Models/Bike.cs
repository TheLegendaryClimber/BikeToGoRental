using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BikeToGoRental.Models
{
    public class Bike
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter bike's name.")]
        [StringLength(50)]
        public string Name { get; set; }
        public SurfaceType SurfaceType { get; set; }
        public byte SurfaceTypeId { get; set; }
        public string Model { get; set; }
        public string Gears { get; set; }
        public string FrameSize { get; set; }

        [Range(1, 10)]
        public byte AmountInStock { get; set; }

        public byte AmountAvailable { get; set; }

        public string BikeImage { get; set; }

    }
}