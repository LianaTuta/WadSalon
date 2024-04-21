using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Salon.DAL.Repository.Interface;
using Salon.Migrations;
using Salon.Model.Models;

namespace Salon.DAL.Repository.Implementation
{
    public class SalonRepository : ISalonRepository
    {
        private readonly SalonContext _context;
        public SalonRepository(SalonContext context)
        {
            _context = context;
        }

        public async Task<List<SalonModel>> GetAllSalons()
        {
            return await _context.Salon.ToListAsync();

        }

        public async Task<SalonModel> GetSalonById(int salonId)
        {
            var salonDetails = await _context.Salon
               .FirstOrDefaultAsync(m => m.Id == salonId);
            return salonDetails;
        }
    }
}
