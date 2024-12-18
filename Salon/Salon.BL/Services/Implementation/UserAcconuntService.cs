using Microsoft.AspNetCore.Identity;
using Salon.BL.Services.Interface;
using Salon.DAL.Repository.Interface;
using Salon.Model.Models;
using Salon.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.BL.Services.Implementation
{
    public class UserAcconuntService : IUserAccountService
    {


        private readonly IUserAccountRepository _userAccountRepository;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUserStore<IdentityUser> _userStore;
        private readonly IUserEmailStore<IdentityUser> _emailStore;
        public UserAcconuntService(
            IUserAccountRepository userAccountRepository,
                  UserManager<IdentityUser> userManager,
                IUserStore<IdentityUser> userStore,
                SignInManager<IdentityUser> signInManager
  )
        {
            _userAccountRepository = userAccountRepository;
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;

        }


        public async Task CreateAccount(UserProfileView userprofile)
        {
            var user = CreateUser();
            await _userStore.SetUserNameAsync(user, userprofile.Email, CancellationToken.None);
            await _emailStore.SetEmailAsync(user, userprofile.Email, CancellationToken.None);
            var result = await _userManager.CreateAsync(user, userprofile.Password);

            if (result.Succeeded)
            {


                var userId = await _userManager.GetUserIdAsync(user);

                await _userAccountRepository.SaveUserProfile(new UserProfile()
                {
                    FirstName = userprofile.FirstName,

                    LastName = userprofile.LastName,
                   
                    AspNetUserId = userId,
                   
                });

                await _userAccountRepository.SaveUserAddress(new UserAddress()
                {
                    City = userprofile.City,
                  AspNetUserId = userId,
      
        Number = userprofile.Number,
        Street = userprofile.Street,
        Country = userprofile.Country
       
    });


            }
        }
        public async Task<bool> CheckEmailAvailability(string email)

        {
            var userProfile = await _userAccountRepository.FindUserProfile(email);
            return userProfile == null ? false : true;
        }

        private IdentityUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<IdentityUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(IdentityUser)}'. " +
                    $"Ensure that '{nameof(IdentityUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<IdentityUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<IdentityUser>)_userStore;
        }

       
    }
}
