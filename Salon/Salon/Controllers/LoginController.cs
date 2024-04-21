using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salon.Migrations;
using Salon.Model.ViewModels;

namespace Salon.Controllers
{
    public class LoginController : Controller
    {
        private readonly SalonContext _context;
        public LoginController(SalonContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginAsync(UserLoginView userLogin)
        {
            var existingUserProfile = await _context.UserLogin
            .FirstOrDefaultAsync(m => m.Email == userLogin.Email);
            var correctPassword = await _context.UserLogin.FirstOrDefaultAsync(m => m.Password == userLogin.Password);
            if (existingUserProfile != null  && correctPassword !=null)
            {
                return RedirectToAction("Overview", "Salons");
            }
            return  RedirectToAction("Login", "Login");
        }
       
    }
}
