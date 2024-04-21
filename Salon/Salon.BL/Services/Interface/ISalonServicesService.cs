using Salon.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.BL.Services.Interface
{
    public interface ISalonServicesService
    {
        Task<List<SalonServiceView>> GetServicesBySalonId(int salonId);
    }
}
