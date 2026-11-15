using Microsoft.AspNetCore.Mvc;

namespace Part2.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Archive(int year, int month) => Content($"Blog posts from {month}/{year}");
    }
}
