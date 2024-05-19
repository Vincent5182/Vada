using System;
using System.ComponentModel.DataAnnotations;
using Vada.Dtos;
using Vada.Models;

namespace Vada.Models
{
    public class Adult : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (CustomerDto)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown ||
                customer.MembershipTypeId == MembershipType.Free)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Date of Birth is required");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Only customers 18+ years old can go on a membership");
        }
    }
}