using Microsoft.AspNetCore.Mvc;

namespace Part2.Controllers
{
    [Route("[controller]/[action]")]
    public class StudentController : Controller
    {
     public IActionResult List() => Content("Students: List");
    
    }
}
