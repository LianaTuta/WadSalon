using Microsoft.EntityFrameworkCore;
using Salon.DAL.Repository.Interface;
using Salon.Migrations;
using Salon.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.DAL.Repository.Implementation
{
    public class UserAccountRepository : IUserAccountRepository
    {
        private readonly SalonContext _context;
        public UserAccountRepository(SalonContext context)
        {
            _context = context;
        }

        public async Task<int> SaveUserProfile(UserProfile userProfile)
        {

            await _context.UserProfile.AddAsync(userProfile);
            await _context.SaveChangesAsync();
            return userProfile.Id;
        }

        public async Task SaveUserLoginDetails(UserLogin userLoginDetails)
        {
            await _context.UserLogin.AddAsync(userLoginDetails);
            await _context.SaveChangesAsync();

        }

        public async Task<int> FindUserProfile(string email)
        {
            var userProfile = await _context.UserLogin.FirstOrDefaultAsync(m => m.Email == email);
            return userProfile.Id;
        }

        public async Task<int> FindFirstOrDefaultUserProfile()
        {
            var userProfile = await _context.UserLogin.FirstOrDefaultAsync();
            return userProfile.Id;
        }
    }
}
