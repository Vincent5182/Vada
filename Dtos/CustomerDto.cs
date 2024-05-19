using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vada.Models;

namespace Vada.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter the customer name")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribed { get; set; }
        [Required(ErrorMessage = "Choose a membership type")]
        public byte MembershipTypeId { get; set; }
        [Adult]
        public DateTime? Birthdate { get; set; }
    }
}