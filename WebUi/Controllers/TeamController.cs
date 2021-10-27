using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUi.Controllers
{
    public class TeamController : Controller
    {
        TeamManager tm = new TeamManager(new EfTeamDal());
        public IActionResult Index()
        {
            var model = tm.GetAll();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(Team t)
        {
           tm.Add(t);
            return RedirectToAction("Index","Team");
        }
    }
}
