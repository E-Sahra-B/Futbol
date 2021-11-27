using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }
        public IActionResult Index()
        {
            var model = _teamService.GetAll();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(Team t)
        {
           _teamService.Add(t);
            return RedirectToAction("Index","Team");
        }
    }
}
