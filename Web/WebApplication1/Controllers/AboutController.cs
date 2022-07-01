using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("wof/about")]

    public class AboutController : Controller
    {
        [Route("Error")] // It is not index anymore as default

        public string Index(string id, string p)
        {
            return "So now 'About' is working too. id=" + id + " p=" + p;
        }
    }
}
