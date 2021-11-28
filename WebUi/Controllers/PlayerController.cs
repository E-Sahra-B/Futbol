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
            TempData["mesaj"] = "eklendi";
            return RedirectToAction("Index", "Player");
        }
        public IActionResult Delete(int id)
        {
            var value = _playerService.GetById(id);
            _playerService.Delete(value);
            TempData["mesaj"] = "silindi";

            return RedirectToAction("Index", "Player");
        }
        public IActionResult ChangeStatusBlog(int id)
        {
            var blogValue = _playerService.GetById(id);
            //if (blogValue.BlogStatus)
            //{
            //    blogValue.BlogStatus = false;
            //}
            //else
            //{
            //    blogValue.BlogStatus = true;
            //}
            _playerService.Update(blogValue);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
