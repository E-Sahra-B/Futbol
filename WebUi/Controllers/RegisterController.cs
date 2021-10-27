using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUi.Controllers
{

    public class RegisterController : Controller
    {
        private IAuthService _authService;

        public RegisterController(IAuthService authService)
        {
            _authService = authService;
        }
        UserManager um = new UserManager(new EfUserDal());
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
