using Microsoft.EntityFrameworkCore;
using Salon.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.DAL.Repository.Interface
{
    public interface IUserAccountRepository
    {
        Task<int> SaveUserProfile(UserProfile userProfile);

        Task SaveUserAddress(UserAddress userAddress);

        Task<int> FindUserProfile(string email);

        Task<int> FindFirstOrDefaultUserProfile();
    }
}
