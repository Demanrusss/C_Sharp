using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public IActionResult Index()
        {
            return View("Index", new Person() { FirstName = "John", LastName = "Doe"});
        }

        public IActionResult Show(int id)
        {
            if (id < 0)
                return BadRequest("ID cannot be negative");

            if (id == 10)
                return Content("Show is working and id=" + id);
            else
                return NotFound();
        }
    }
}
