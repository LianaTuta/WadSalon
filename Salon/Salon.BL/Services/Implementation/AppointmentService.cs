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
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IUserAccountRepository _userAccountRepository;
        private readonly ISalonServiceRepository _salonServiceRepository;
        private readonly ISalonRepository _salonRepository;
        public AppointmentService(
            IAppointmentRepository appointmentRepository, 
            IUserAccountRepository userAccountRepository,
            ISalonServiceRepository salonServiceRepository,
            ISalonRepository salonRepository)
        {
            _appointmentRepository = appointmentRepository;
            _userAccountRepository = userAccountRepository;
            _salonServiceRepository = salonServiceRepository;
            _salonRepository = salonRepository; 
        }
        public async Task SaveAppoinment(string userId, int serviceId, int salonId, DateTime appointmentDate)
        {
          
            await _appointmentRepository.SaveAppointment(new Appoinment()
            {
                ServiceId = serviceId,
                AppoinmentDate = appointmentDate,
                AspNetUserId = userId,
            });
        }

        public async Task<List<AppoinmentViewModel>> GetUserAppoinmentsAsync(string userId)
        {
            var appoinments = await _appointmentRepository.GetAppointments(userId);
            var view = new List<AppoinmentViewModel>();
            foreach(var app in appoinments)
            {
                var service = await _salonServiceRepository.GetServicesById(app.ServiceId);
                service.Salon = await _salonRepository.GetSalonById(service.SalonId);
                view.Add( new AppoinmentViewModel() { Id = app.Id, Service = service, AppoinmentDate = app.AppoinmentDate });
            }
            return view;
        }

        public async Task UpdateAppointment(int  id, DateTime date)
        {
            var appointment = await  _appointmentRepository.GetAppointmentById(id);
            appointment.AppoinmentDate = date;
            if (appointment != null)
            {
                await _appointmentRepository.UpdateAppointment(appointment);
            }
            
        }

        public async Task DeleteAppointment(int id)
        {
            var appointment = await _appointmentRepository.GetAppointmentById(id);
            if (appointment != null)
            {
                await _appointmentRepository.DeleteAppointment(appointment);
            }
        }
        
    }
}
