using Microsoft.AspNetCore.Mvc;
using Salon.BL.Services.Interface;
using Salon.Model.ViewModels;

namespace Salon.Controllers
{
    public class UserProfileController : Controller
    {
        private readonly IUserAccountService _userAccountService; 
        public UserProfileController(IUserAccountService userAcconuntService)
        {
           _userAccountService = userAcconuntService;
        }

        public async Task<IActionResult> CreateAccount(UserProfileView userProfile)
        {
            return View(userProfile);
        }

        [HttpPost]
        public async Task<IActionResult> SaveAccountAsync(UserProfileView userProfile)
        {

            await _userAccountService.CreateAccount(userProfile);
            return RedirectToAction("Login", "Login");
        }
    }
}
