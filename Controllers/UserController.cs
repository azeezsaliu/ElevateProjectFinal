using Microsoft.AspNetCore.Mvc;

namespace ElevateProjectFinal.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
