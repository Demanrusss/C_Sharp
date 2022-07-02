using Microsoft.AspNetCore.Mvc;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult List()
        {
            Person[] people = new Person[]
            {
                new Person { FirstName = "Ivan", LastName = "Ivanov", Age = 10},
                new Person { FirstName = "Petr", LastName = "Petrov", Age = 20},
                new Person { FirstName = "Michail", LastName = "Flenov", Age = 45}
            };

            return View(people);
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Welcome";
            return View("Index", new Person() { FirstName = "John", LastName = "Doe", Age = 10});
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
