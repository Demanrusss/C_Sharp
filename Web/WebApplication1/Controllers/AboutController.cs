using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("about")]

    public class AboutController : Controller
    {
        [Route("index")]

        public IActionResult Index()
        {
            return View();
        }
    }

    [Route("wof/about")]

    public class WofAboutController: Controller
	{
        [Route("error")]

        public string About()
		{
            return "This is really About-page but the address is different";
		}
	}
}
