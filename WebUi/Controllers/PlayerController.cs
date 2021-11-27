using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public IActionResult Index()
        {
            var model = _playerService.GetAll();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(Player p)
        {
            _playerService.Add(p);
            return RedirectToAction("Index", "Player");
        }
    }
}
