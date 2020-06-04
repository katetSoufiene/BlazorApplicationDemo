using Blazor.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorServer.Models
{
    public class EditEmployeeModel
    {
        public int EmployeeId { get; set; }   

        [Required(ErrorMessage = "FirstName is mandatory")]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is mandatory")]
        public string LastName { get; set; }

        [EmailDomainValidator(AllowedDomain = "soufiene.com", ErrorMessage = "Domain must be gmail.com")]
        [EmailAddress]
        public string Email { get; set; }
        public string ConfirmEmail { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        [ValidateComplexType]
        public Department Department { get; set; }
        public string PhotoPath { get; set; }

    }
}
