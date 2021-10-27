using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUi.Controllers
{
    public class AboutController : Controller
    {
        //private IAboutService _aboutService;

        //public AboutController(IAboutService aboutService)
        //{
        //    _aboutService = aboutService;
        //}
        AboutManager abm = new AboutManager(new EfAboutDal());
        public IActionResult Index()
        {
            var model = abm.GetAll();
            return View(model);
        }
    }
}
