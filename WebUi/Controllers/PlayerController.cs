using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers
{
    public class PlayerController : Controller
    {
        PlayerManager pm = new PlayerManager(new EfPlayerDal());
        public IActionResult Index()
        {
            var model = pm.GetAll();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(Player p)
        {
            pm.Add(p);
            return RedirectToAction("Index", "Player");
        }
    }
}
