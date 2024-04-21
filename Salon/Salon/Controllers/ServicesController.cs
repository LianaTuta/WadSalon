using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salon.BL.Services.Interface;
using Salon.Migrations;
using Salon.Model.Models;

namespace Salon.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ISalonServicesService _salonServicesService;
        public ServicesController(ISalonServicesService salonServicesService)
        {
            _salonServicesService = salonServicesService;
        }
        [HttpGet]
        public async Task<IActionResult> ServicesAsync(int salonId)
        {

            var services = await _salonServicesService.GetServicesBySalonId(salonId);   
            ViewBag.Services = services;
            return View(services);
        }

        public IActionResult SuccessfullBook(SalonService serviceModel)
        {
            return View(serviceModel);
        }
    }
}
