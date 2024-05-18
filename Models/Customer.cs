using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vada.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter the customer name")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribed { get; set; }
        public MembershipType MembershipType { get; set; }
        [Required(ErrorMessage = "Choose a membership type")]
        public byte MembershipTypeId { get; set; }
        [Adult]
        public DateTime? Birthdate { get; set; }
    }
}