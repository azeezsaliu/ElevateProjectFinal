using ElevateProjectFinal.Models;
using ElevateProjectFinal.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElevateProjectFinal.Controllers
{
    public class AccountController : Controller
    {
        IUserService userService;
        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            userService.Create(user);
            return View();
        }
    }
}
