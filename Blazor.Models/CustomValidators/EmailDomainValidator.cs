﻿using System.ComponentModel.DataAnnotations;
namespace Blazor.Models
{
    public class EmailDomainValidator : ValidationAttribute
    {
        public string AllowedDomain { get; set; }

        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            if (value == null)
            {
                return null;
            }


            string[] strings = value.ToString().Split('@');
            if (strings.Length > 1 && strings[1].ToUpper() == AllowedDomain.ToUpper())
            {
                return null;
            }

            return new ValidationResult(ErrorMessage,
            new[] { validationContext.MemberName });

        }
    }

}
