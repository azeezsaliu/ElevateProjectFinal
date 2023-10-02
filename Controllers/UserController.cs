using ElevateProjectFinal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ElevateProjectFinal.Controllers
{
    public class UserController : Controller
    {
        private UserManager<User> userManager;
        private SignInManager<User> signInManager;
        private RoleManager<IdentityRole> roleManager;

        public UserController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager) 
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CreateAsync(User user)
        {
            


            IdentityResult identityResult = await userManager.CreateAsync(user, user.Password);
            if (identityResult.Succeeded)
            {
                await roleManager.CreateAsync(new IdentityRole("Instructor"));

                return RedirectToAction("Index", "Home");
            }
            foreach (IdentityError err in identityResult.Errors)
            {
                ModelState.AddModelError("", err.Description);
            }


            return View();
        }
    }
}
