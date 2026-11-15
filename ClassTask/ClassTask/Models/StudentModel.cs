using System.ComponentModel.DataAnnotations;

namespace ClassTask.Models
{
    public class StudentModel
    {
        [Display(Name = "Student Name")]
        [Required(ErrorMessage = "Student Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be 3-50 characters")]
        public required string name { get; set; }

        [Display(Name = "Student Email")]
        [Required(ErrorMessage = "Student Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email must be like name@example.com")]
        public required string email { get; set; }

        [Display(Name = "Course Code")]
        [Required(ErrorMessage = "Course Code is required")]
        [StringLength(10, ErrorMessage = "Course Code cannot be longer than 10 characters")]
        public required string courseCode { get; set; }

        [Display(Name = "Credit Hour")]
        [Required(ErrorMessage = "Credit Hour is required")]
        [Range(1, 4, ErrorMessage = "Credit Hour must be between 1 and 4")]
        public required int hour { get; set; }

        [Display(Name = "Semester Fee")]
        [Required(ErrorMessage = "Semester Fee is required")]
        [Range(5000,100000 , ErrorMessage = "Semester Fee must be between 5000 and 100000")]
        public required int semesterfee { get; set; }
    }
}
