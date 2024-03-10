using Microsoft.AspNetCore.Mvc;
using Salon.Models;

namespace Salon.Controllers
{
    public class LoginController : Controller
    {
        [BindProperty]
        public UserLoginModel? userLogin { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserLoginModel u)
        {
         
           return RedirectToAction("Privacy","Home");
          

            return View(u);
        }
       
    }
}
