using Microsoft.AspNetCore.Mvc;

namespace ElevateProjectFinal.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
