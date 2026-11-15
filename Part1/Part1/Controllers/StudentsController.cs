using Microsoft.AspNetCore.Mvc;

namespace Part1.Controllers
{
    public class StudentsController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hello()
        {
            return Content("Hello Siam How are you");
        }

        public IActionResult info()
        {
            var student = new { name = "Siam", age = 22 };
            return Json(student);
        }

        public IActionResult Download()
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes("This file came from a controller");
            return File(bytes,"text/plain","hello.txt");
        }

        public IActionResult GoHome()
        {
            return RedirectToAction("Index");
        }
        public IActionResult Missing()
        {
            return NotFound();
        }
        public IActionResult Noview()
        {
            return View();
        }

    }
}
