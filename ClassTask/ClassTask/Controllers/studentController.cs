using ClassTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassTask.Controllers
{
    public class studentController : Controller
    {
        
        private static readonly List<StudentModel> students = new()
        {
           
        };

       
        public IActionResult Index()
        {
            return View(students);
        }

        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StudentModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

     
            students.Add(model);
            return RedirectToAction(nameof(Index));
        }
    }
}
