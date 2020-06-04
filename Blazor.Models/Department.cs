using System.ComponentModel.DataAnnotations;

namespace Blazor.Models
{
    // Department Class

    public class Department
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
