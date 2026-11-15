using System.ComponentModel.DataAnnotations;

namespace Module4.Models
{
    public class student
    {
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        public string Name { get; set; } = string.Empty;

        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100")]
        public int Age { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; } = string.Empty;
    }
}
