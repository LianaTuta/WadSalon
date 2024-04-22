using Salon.BL.Services.Interface;
using Salon.DAL.Repository.Interface;
using Salon.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.BL.Services.Implementation
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IUserAccountRepository _userAccountRepository;
        public AppointmentService(IAppointmentRepository appointmentRepository, IUserAccountRepository userAccountRepository)
        {
            _appointmentRepository = appointmentRepository;
            _userAccountRepository = userAccountRepository;
        }
        public async Task SaveAppoinment(int serviceId, int salonId, DateTime appointmentDate)
        {
            var userId =await  _userAccountRepository.FindFirstOrDefaultUserProfile();
            await _appointmentRepository.SaveAppointment(new Appoinment()
            {
                ServiceId = serviceId,
                AppoinmentDate = appointmentDate,
                UserLoginId = userId,
            });
        }
    }
}
