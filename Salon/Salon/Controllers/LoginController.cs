using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salon.Migrations;
using Salon.Model.ViewModels;

namespace Salon.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginController> _logger;
        public LoginController( 
            SignInManager<IdentityUser> signInManager,
             ILogger<LoginController> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginAsync(UserLoginView userLogin)
        {
            var result = await _signInManager.PasswordSignInAsync(userLogin.Email, userLogin.Password, true, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                _logger.LogInformation("User logged in.");
                return RedirectToAction("Overview", "Salons");
            }

            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return RedirectToAction("Login", "UserAccount");
            }
        }
       
    }
}
