using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUi.Controllers
{
    public class FutbolController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
