using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? DoB { get; set; }

        public bool IsSuscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }


        [Required]
        [Display(Name = "Membership Type")]
        [Min18Member]
        public byte MembershipTypeId { get; set; }


    }
}