using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Salon.BL.Services.Interface;
using System.Security.Claims;

namespace Salon.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ISalonServicesService _salonServicesService;
        private readonly IAppointmentService _appointmentService;
        public ServicesController(ISalonServicesService salonServicesService, IAppointmentService appointmentService)
        {
            _salonServicesService = salonServicesService;
            _appointmentService = appointmentService;
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> ServicesAsync(int salonId)
        {

            var services = await _salonServicesService.GetServicesBySalonId(salonId);
            
            return View(services);
        }

        [Authorize]
        public async Task<IActionResult> SuccessfulBook(int id, int salonId, DateTime appointmentDate)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            await _appointmentService.SaveAppoinment(userId, id,salonId, appointmentDate);
            return View();
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> UserAppointments()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var appointments = await _appointmentService.GetUserAppoinmentsAsync(userId);
            return View(appointments);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> EditAppointment(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var appointments = await _appointmentService.GetUserAppoinmentsAsync(userId);
           
            return View(appointments.Where(a => a.Id == id).FirstOrDefault());
        }

        [Authorize]
       
        public async Task<IActionResult> SavedUpdatedAppointment(int id, DateTime date)
        {
             await _appointmentService.UpdateAppointment(id, date);
            return RedirectToAction("UserAppointments", "Services");
        }


        [Authorize]

        public async Task<IActionResult> DeleteAppointment(int id)
        {
            await _appointmentService.DeleteAppointment(id);
            return RedirectToAction("UserAppointments", "Services");
        }
    }
}
