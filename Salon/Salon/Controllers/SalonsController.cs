using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salon.DAL;
using Salon.Models;
using System.Runtime.Intrinsics.X86;

namespace Salon.Controllers
{
    public class SalonsController : Controller
    {
        private readonly SalonContext _context;
        public SalonsController(SalonContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> OverviewAsync()
        {
            var list = await _context.Salon.ToListAsync();
            ViewBag.SalonList = list;
            return View(list.ToList());
        }

        [HttpGet]
        public async Task<IActionResult> SalonDetailsAsync(int salonId)
        {
            var salonDetails = await _context.Salon
               .FirstOrDefaultAsync(m => m.Id == salonId);
            ViewBag.Salon = salonDetails;
            return View(salonDetails);
        }
    }
}
