using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseProblems.Models;

[Table("Employee")]   // the table in SSMS is called Employee (not Employees)
public class Employee
{
    [Key]
    public int EmpId { get; set; }

    [Required]
    [StringLength(100)]
    public string EmpName { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Department { get; set; } = string.Empty;

    [Range(0, 1000000)]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Salary { get; set; }

    [Range(0, 50)]
    public int ExperienceYears { get; set; }

    [DataType(DataType.Date)]
    public DateTime JoinedAt { get; set; }
}