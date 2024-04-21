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
    public class SalonServicesService : ISalonServicesService
    {
        private readonly ISalonServiceRepository _salonServiceRepository;
        public SalonServicesService(ISalonServiceRepository salonServiceRepository)
        {
             _salonServiceRepository = salonServiceRepository;
        }
        public async Task<List<SalonServiceView>> GetServicesBySalonId(int salonId)
        {
            var salonServices = (await _salonServiceRepository.GetServicesBySalonId(salonId)).Select( s=>  new SalonServiceView()
            {
                SalonId = s.SalonId,
                Id = s.Id,
                AppointmentDate = DateTime.Now,
                Description = s.Description,
                Name = s.Name
            }).ToList();
            return salonServices;
        }

    }
}
