using Salon.BL.Services.Interface;
using Salon.DAL.Repository.Interface;
using Salon.Model.Models;

namespace Salon.BL.Services.Implementation
{
    public class SalonsService : ISalonService
    {
        private readonly ISalonRepository _salonRepository;
        public SalonsService(ISalonRepository salonRepository)
        {
            _salonRepository = salonRepository;
        }
        public async Task<List<SalonModel>> GetAllSalons()
        {
            return await _salonRepository.GetAllSalons();
        }

        public async Task<SalonModel> GetSalonById(int salonId)
        {
            return await _salonRepository.GetSalonById(salonId);
        }
    }
}
