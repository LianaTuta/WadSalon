using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salon.BL.Services.Interface;
using Salon.Migrations;
using Salon.Model.Models;
using Salon.Model.ViewModels;

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
        [HttpGet]
        public async Task<IActionResult> ServicesAsync(int salonId)
        {

            var services = await _salonServicesService.GetServicesBySalonId(salonId);
            SalonServiceViewList salonServiceList = new SalonServiceViewList()
            {
                List = services
            };
            ViewBag.SalonServices = services;
            
            return View(salonServiceList.List.FirstOrDefault());
        }

        public async Task<IActionResult> SuccessfulBook(int id, int salonId, DateTime appointmentDate)
        {
            await _appointmentService.SaveAppoinment(id,salonId, appointmentDate);
            
            return View();
        }
    }
}
