using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    //[Authorize]
    [AllowAnonymous]
    public class AdminBaseController : Controller
    {
    }
}
