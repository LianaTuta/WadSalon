using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.BL.Services.Interface
{
    public interface IAppointmentService
    {
         Task SaveAppoinment(int serviceId, int salonId, DateTime appointmentDate);
    }
}
