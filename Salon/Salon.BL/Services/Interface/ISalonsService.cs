using Salon.Model.Models;

namespace Salon.BL.Services.Interface
{
    public interface ISalonService
    {
        Task<List<SalonModel>> GetAllSalons();
        Task<SalonModel> GetSalonById(int salonId);

    }
}
