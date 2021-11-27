using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IAuthService _authService;

        public RegisterController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserForRegisterDto u)
        {
            var x = _authService.Register(u, u.Password);
            var y = _authService.CreateAccessToken(x.Data);
            return RedirectToAction("Index","Register");
        }
    }
}
