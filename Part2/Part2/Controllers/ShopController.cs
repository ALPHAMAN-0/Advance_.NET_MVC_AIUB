using Microsoft.AspNetCore.Mvc;

namespace Part2.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult List() => Content("Shop: List of all items");
        public IActionResult Details(int id) => Content($"Shop: item {id}");
    }
}
