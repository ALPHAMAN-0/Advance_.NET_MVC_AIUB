using Microsoft.AspNetCore.Mvc;

namespace Part2.Controllers
{
    public class ProductController : Controller
    {
        //converntional Routing
        public IActionResult Index()
        {
            return Content("Product : Index");
        }
        public IActionResult List()
        {
            return Content("Product : List");
        }
        public IActionResult Details(int id)
        {
            return Content($"Product Id = {id}");
        }

        //attribute routing  2 URL one action
        [Route("products/special/{id:int:min(1)}")]
        [Route("item/{id:int:min(1)}")]
        public IActionResult Special(int id) => Content($"Special product {id}");
    }
}
