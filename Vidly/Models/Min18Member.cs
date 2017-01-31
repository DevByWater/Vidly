
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18Member: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.DoB == null)
                return new ValidationResult("Your birthday is required");

            var age = DateTime.Today.Year - customer.DoB.Value.Year;

            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Must be at least 18 years old. To suscribe to that plan");
        }
    }
}