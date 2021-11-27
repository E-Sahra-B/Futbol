using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers
{
    public class FutbolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
