using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers
{
    public class MatchController : Controller
    {
        private readonly IMatchService _matchService;
        public MatchController(IMatchService matchService)
        {
            _matchService = matchService;
        }
        public IActionResult Index()
        {
            var model = _matchService.GetAll();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(Match m)
        {
            _matchService.Add(m);
            return RedirectToAction("Index", "Match");
        }
    }
}
