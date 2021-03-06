using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebUi.Areas.Admin.Models;
using X.PagedList;

namespace WebUi.Controllers
{
    public class MatchController : Controller
    {
        private IMatchService _matchService;
        private readonly ITeamService _teamService;
        public MatchController(IMatchService matchService, ITeamService teamService)
        {
            _matchService = matchService;
            _teamService = teamService;
        }
        public IActionResult Index(int page = 1)
        {
            var model = new MatchAddViewModel
            {
                Match = new Match(),
                Teams = _teamService.GetAll()
            };
           TempData= _matchService.GetAll.ToPagedList(page, 5);
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(Match m)
        {
            _matchService.Add(m);
            TempData["mesaj"] = "eklendi";
            return RedirectToAction("Index", "Match");
        }
        public IActionResult Delete(int id)
        {
            var value = _matchService.GetById(id);
            _matchService.Delete(value);
            TempData["mesaj"] = "silindi";
            return RedirectToAction("Index", "Match");
        }
    }
}
