using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salon.BL.Services.Interface;
using Salon.Migrations;

namespace Salon.Controllers
{
    public class SalonsController : Controller
    {
        private readonly ISalonService _salonService;
        public SalonsController(ISalonService salonService)
        {
            _salonService = salonService;
        }

        [HttpGet]
        public async Task<IActionResult> OverviewAsync()
        {
            var salons = await _salonService.GetAllSalons();
            ViewBag.SalonList = salons;
            return View(salons);
        }

        [HttpGet]
        public async Task<IActionResult> SalonDetailsAsync(int salonId)
        {
            var salonDetails = await _salonService.GetSalonById(salonId);
            ViewBag.Salon = salonDetails;
            return View(salonDetails);
        }
    }
}
