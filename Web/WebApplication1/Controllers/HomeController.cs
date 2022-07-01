using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello again. Home is working";
        }

        public string Show()
        {
            return "Show is working";
        }
    }
}
