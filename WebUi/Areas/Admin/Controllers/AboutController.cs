using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUi.Areas.Admin.Controllers
{
    public class AboutController : AdminBaseController
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Update()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Update(About t)
        {
            _aboutService.Update(t);
            TempData["mesaj"] = "Güncellendi";
            return RedirectToAction("Update", "About", "Admin");
        }
    }
}
