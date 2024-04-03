using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salon.DAL;
using Salon.Models;

namespace Salon.Controllers
{
    public class UserProfileController : Controller
    {
        private readonly SalonContext _context;
        public UserProfileController(SalonContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> CreateAccount(UserProfileView userProfile)
        {
            return View(userProfile);
        }
        [HttpPost]
        public async Task<IActionResult> SaveAccountAsync(UserProfileView userProfile)
        {
            var existingUserProfile = await _context.UserProfile
             .FirstOrDefaultAsync(m => m.Email == userProfile.Email);
            if(existingUserProfile == null)
            {
                _context.UserProfile.Add(new UserProfile()
                {
                    Email = userProfile.Email,
                    FirstName = userProfile.FirstName,
                    LastName = userProfile.LastName,
                });
                _context.SaveChanges();
                var cuurentUserProfile = await _context.UserProfile
                    .FirstOrDefaultAsync(m => m.Email == userProfile.Email);
                _context.UserAddress.Add(new UserAddress()
                {
                    UserProfileId = cuurentUserProfile.Id,
                    Number = userProfile.Number,
                    Street = userProfile.Street,
                    City = userProfile.City,
                    Country = userProfile.Country
                });
                _context.UserPassword.Add(new UserPassword()
                {
                    UserProfileId = cuurentUserProfile.Id,
                    Password = userProfile.Password,
                });
                _context.SaveChanges();
                return RedirectToAction("Login", "Login");
            }
            return RedirectToAction(nameof(CreateAccount));
        }
    }
}
