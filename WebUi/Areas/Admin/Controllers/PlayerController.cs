using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;


namespace WebUi.Areas.Admin.Controllers
{
    public class PlayerController : AdminBaseController
    {
        private readonly IPlayerService _playerService;
        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }
        public IActionResult Index(int page=1)
        {
            var model = _playerService.GetAll().ToPagedList(page, 5);
            return View(model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Player t)
        {
            _playerService.Add(t);
            TempData["mesaj"] = "Futbolcu eklendi";
            return RedirectToAction("Add", "Player", "Admin");
        }
    }
}
