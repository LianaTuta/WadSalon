using Microsoft.EntityFrameworkCore;
using Salon.Model.Models;

namespace Salon.DAL.Repository.Interface
{
    public interface ISalonServiceRepository
    {
        Task<List<SalonService>> GetServicesBySalonId(int salonId);
        Task<SalonService> GetServicesById(int id);

    }
}
