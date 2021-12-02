using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace WebUi.Areas.Admin.Controllers
{
    public class TeamController : AdminBaseController
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }
        public IActionResult Index(int page=1)
        {
            var model = _teamService.GetAll().ToPagedList(page, 5);
            return View(model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Add(Team t)
        {
            _teamService.Add(t);
            TempData["mesaj"] = "eklendi";
            return RedirectToAction("Add", "Team","Admin");
        }

    }
}
