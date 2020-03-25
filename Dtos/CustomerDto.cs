using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using BikeToGoRental.Models;

namespace BikeToGoRental.Dtos
{
    public class CustomerDto
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(50)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        [Required(ErrorMessage = "Please select membership type.")]

        public byte MembershipTypeId { get; set; }

        [Required(ErrorMessage = "Please type in your birthdate. Fx: 1 Jan 1980")]
        [Min18Years]
        public DateTime? Birthdate { get; set; }
    }
}