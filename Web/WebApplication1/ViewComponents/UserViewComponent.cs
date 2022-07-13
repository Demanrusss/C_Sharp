using System;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.ViewModel;

namespace WebApplication1.ViewComponents
{
    public class UserViewComponent : ViewComponent
    {
        public UserViewComponent()
        {

        }

        public IViewComponentResult Invoke()
        {
            var model = new Person()
            {
                IsLoggedIn = true,
                UserName = "demanrusss"
            };

        return View("User", model);
        }
    }
}