using System.ComponentModel.DataAnnotations;

namespace ClassTask.Models
{
    public class EnrollmentModel
    {
        [Required(ErrorMessage = "Student name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be 3-50 characters")]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Student ID is required")]
        [RegularExpression(@"^\d{2}-\d{5}-\d$", ErrorMessage = "Format must be like 22-12345-1")]
        [Display(Name = "Student ID")]
        public string StudentId { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Course name is required")]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Credit is required")]
        [Range(1, 4, ErrorMessage = "Credit must be between 1 and 4")]
        public int? Credit { get; set; }

        [Required(ErrorMessage = "Enrollment date is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Enrollment Date")]
        public DateTime? EnrollmentDate { get; set; }
    }
}
