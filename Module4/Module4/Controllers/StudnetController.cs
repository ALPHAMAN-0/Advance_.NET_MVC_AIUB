using Microsoft.AspNetCore.Mvc;
using Module4.Models;

namespace Module4.Controllers
{
    public class StudnetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Greet(string? name)
        {
            return Content($"Hello {name}");
        }

        public IActionResult Filter([FromQuery] int page, [FromQuery] String? sort)
        {
            return Content($"Page: {page}, Sort: {sort}");
        }


        [HttpGet]
        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult create(student students)
        {
            if (ModelState.IsValid)
            {
                return View(students);
            }
            return View(students);
        }
        public IActionResult Success()
        {
            return Content("Saved Successfully");
        }
    }
}
