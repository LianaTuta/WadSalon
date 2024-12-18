using Salon.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.DAL.Repository.Interface
{
    public interface IAppointmentRepository
    {
        Task SaveAppointment(Appoinment appoinment);
        Task<List<Appoinment>> GetAppointments(string userId);

        Task UpdateAppointment(Appoinment appoinment);
        Task DeleteAppointment(Appoinment appoinment);

        Task<Appoinment?> GetAppointmentById(int id);

    }
}
