using Microsoft.AspNetCore.Mvc;

using Module3.Models;

namespace Module3.Controllers;
public class StudentsController : Controller
{
    private static List<StudentModel> AllStudents() => new()
    {
        new StudentModel { Name = "John", Age = 22, IsActive = true },
        new StudentModel { Name = "Maria", Age = 19, IsActive = false },
        new StudentModel { Name = "Ahmed", Age = 24, IsActive = true }
    };

    // /Students/Details → one student (strongly-typed view)
    public IActionResult Details()
    {
        var student = new StudentModel { Name = "John", Age = 22, IsActive = true, Description = "<b>Top student</b>" };
        return View(student);
    }

    // /Students/List → many students (loop + partial view)
    public IActionResult List() => View(AllStudents());

    // /Students/Message → ViewBag and ViewData
    public IActionResult Message()
    {
        ViewBag.Message = "Hello from ViewBag!";
        ViewData["Title"] = "Messages";
        return View();
    }
}