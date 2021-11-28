using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebUi.Areas.Admin.Models;

namespace WebUi.Areas.Admin.Controllers
{
    public class MatchController : AdminBaseController
    {
        private readonly IMatchService _matchService;
        private readonly ITeamService _teamService;
        public MatchController(IMatchService matchService, ITeamService teamService)
        {
            _matchService = matchService;
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            var model = new MatchAddViewModel
            {
                Match = new Match(),
                Teams = _teamService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(Match t)
        {
            if (ModelState.IsValid)
            {
                _matchService.Add(t);
                TempData["mesaj"] = "Maç eklendi";
            }

            return RedirectToAction("Add", "Match", "Admin");
        }
        public IActionResult Update(int Id)
        {
            var model = new MatchUpdateViewModel
            {
                Match = _matchService.GetById(Id),
                Teams = _teamService.GetAll()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(Match t)
        {
            if (ModelState.IsValid)
            {
                _matchService.Update(t);
                TempData.Add("message", "ürün güncellendi :D");
            }
            return RedirectToAction("update");
        }
        public IActionResult Delete(int id)
        {
            var value = _matchService.GetById(id);
            _matchService.Delete(value);
            TempData["mesaj"] = "silindi";
            return RedirectToAction("Index", "Match","Admin");
        }
    }
}
