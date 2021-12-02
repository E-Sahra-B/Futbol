using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace WebUi.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }
        public IActionResult Index(int page=1)
        {
            var model = _teamService.GetAll().ToPagedList(page, 5); ;
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(Team t)
        {
            _teamService.Add(t);
            TempData["mesaj"] = "eklendi";
            return RedirectToAction("Index", "Team");
        }
        public IActionResult Delete(int id)
        {
            var value = _teamService.GetById(id);
            _teamService.Delete(value);
            TempData["mesaj"] = "silindi";
            return RedirectToAction("Index", "Team");
        }
    }
}
