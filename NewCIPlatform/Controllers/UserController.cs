using Microsoft.AspNetCore.Mvc;

namespace NewCIPlatform.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
