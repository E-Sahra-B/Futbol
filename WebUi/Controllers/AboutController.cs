using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutservice;

        public AboutController(IAboutService aboutservice)
        {
            _aboutservice = aboutservice;
        }
        public IActionResult Index()
        {
            var model = _aboutservice.GetAll();
            return View(model);
        }
    }
}
