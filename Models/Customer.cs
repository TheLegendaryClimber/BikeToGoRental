using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BikeToGoRental.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(50)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }

        [Required(ErrorMessage = "Please select membership type.")]
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Required(ErrorMessage = "Please type in your birthdate. Fx: 1 Jan 1980")]
        [Display(Name = "Date of Birth")]
        [Min18Years]
        public DateTime? Birthdate { get; set; }
    }
}