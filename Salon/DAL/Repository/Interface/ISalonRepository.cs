using Salon.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.DAL.Repository.Interface
{
    public interface ISalonRepository
    {
        Task<List<SalonModel>> GetAllSalons();
        Task<SalonModel> GetSalonById(int salonId);
    }
}
