using Microsoft.AspNetCore.Mvc;

namespace WebUi.Areas.Admin.Controllers
{
    public class AdminController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult AdminNavbarPartial()
        {
            return PartialView();
        }
    }
}
