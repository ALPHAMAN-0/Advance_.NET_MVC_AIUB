using ClassTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassTask.Controllers
{
    public class EnrollmentController : Controller
    {
        
        [HttpGet]
        public IActionResult Create()
        {
            return View(new EnrollmentModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EnrollmentModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ViewBag.Message = $"{model.StudentName} enrolled in {model.CourseName} successfully!";
            ModelState.Clear();
            return View(new EnrollmentModel());
        }
    }
}
