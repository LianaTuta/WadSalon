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
        public UserAcconuntService(IUserAccountRepository userAccountRepository)
        {
            _userAccountRepository = userAccountRepository;
        } 
        public async Task CreateAccount(UserProfileView userProfile)
        {
            await _userAccountRepository.SaveUserLoginDetails(new UserLogin()
            {
                Email = userProfile.Email,
                Password = userProfile.Password
            });
            var id = await _userAccountRepository.FindUserProfile(userProfile.Email);
            await _userAccountRepository.SaveUserProfile(new UserProfile()
            {
                FirstName = userProfile.FirstName, 
                LastName = userProfile.LastName,
                UserLoginId = id
            });
        }
    }
}
