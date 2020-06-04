using System;
using System.ComponentModel.DataAnnotations;

namespace Blazor.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "FirstName is mandatory")]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is mandatory")]
        public string LastName { get; set; }

        [EmailDomainValidator(AllowedDomain = "soufiene.com", ErrorMessage = "Domain must be soufiene.com")]
        [EmailAddress]
        public string Email { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }

      
        public Department Department { get; set; }
        public string PhotoPath { get; set; }
    }
}
