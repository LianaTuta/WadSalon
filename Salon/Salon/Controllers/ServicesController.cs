using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salon.DAL;
using Salon.Models;

namespace Salon.Controllers
{
    public class ServicesController : Controller
    {
        private readonly SalonContext _context;
        public ServicesController(SalonContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> ServicesAsync(int salonId)
        {

            var services = await _context.Service.ToListAsync();     
            ViewBag.Services = services;
            return View(services);
        }

        public IActionResult SuccessfullBook(SalonService serviceModel)
        {
            return View(serviceModel);
        }
    }
}
