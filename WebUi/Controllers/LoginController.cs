using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUi.Controllers
{
    public class LoginController : Controller
    {
        private IAuthService _authService;

        public LoginController(IAuthService authService)
        {
            _authService = authService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserForLoginDto u)

        {
            var x = _authService.Login(u);
            var result = _authService.CreateAccessToken(x.Data);
            return RedirectToAction("Index", "Team");
        }
    }
}
