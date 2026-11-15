using Microsoft.AspNetCore.Mvc;
using DatabaseProblems.Data;
using DatabaseProblems.Models;

namespace DatabaseProblems.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly TempDbContext _context;

        public EmployeesController(TempDbContext context)
        {
            _context = context;
        }

        // Q3(a) All employees, newest joiner first
        public IActionResult Index()
        {
            var employees = _context.Employees
                .OrderByDescending(e => e.JoinedAt)
                .ToList();

            ViewData["Title"] = "All Employees";
            return View(employees);
        }

        // Q3(b) More than 5 years of experience, highest salary first
        public IActionResult SeniorEmployees()
        {
            var seniors = _context.Employees
                .Where(e => e.ExperienceYears > 5)
                .OrderByDescending(e => e.Salary)
                .ToList();

            ViewData["Title"] = "Senior Employees";
            return View("Index", seniors);   // reuse the same list view
        }

        // Q3(c) Average salary of each department, highest average first
        public IActionResult DepartmentAverage()
        {
            var averages = _context.Employees
                .GroupBy(e => e.Department)
                .Select(g => new DepartmentAverageViewModel
                {
                    Department = g.Key,
                    AverageSalary = g.Average(e => e.Salary)
                })
                .OrderByDescending(d => d.AverageSalary)
                .ToList();

            return View(averages);
        }

        // BONUS: the highest-paid employee of each department
        public IActionResult HighestPaidPerDepartment()
        {
            var topPaid = _context.Employees
                .GroupBy(e => e.Department)
                .OrderBy(g => g.Key)                                      // departments A to Z
                .Select(g => g.OrderByDescending(e => e.Salary).First())  // top salary in each
                .ToList();

            return View(topPaid);
        }
    }
}
