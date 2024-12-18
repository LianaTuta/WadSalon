using Salon.Model.Models;
using Salon.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.BL.Services.Interface
{
    public interface IAppointmentService
    {
        Task SaveAppoinment(string UserId, int serviceId, int salonId, DateTime appointmentDate);
        Task<List<AppoinmentViewModel>> GetUserAppoinmentsAsync(string userId);
        Task UpdateAppointment(int id, DateTime date);
        Task DeleteAppointment(int id);
    }
}
