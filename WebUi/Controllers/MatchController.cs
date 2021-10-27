using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers
{
    public class MatchController : Controller
    {
        MatchManager mm = new MatchManager(new EfMatchDal());
        public IActionResult Index()
        {
            var model = mm.GetAll();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(Match m)
        {
            mm.Add(m);
            return RedirectToAction("Index", "Match");
        }
    }
}
