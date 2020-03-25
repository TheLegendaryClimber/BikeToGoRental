using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using BikeToGoRental.Models;

namespace BikeToGoRental.Dtos
{
    public class BikeDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter bike's name.")]
        [StringLength(50)]
        public string Name { get; set; }
        public byte SurfaceTypeId { get; set; }
        public string Model { get; set; }
        public string Gears { get; set; }
        public string FrameSize { get; set; }
        public int AmountInStock { get; set; }
    }
}