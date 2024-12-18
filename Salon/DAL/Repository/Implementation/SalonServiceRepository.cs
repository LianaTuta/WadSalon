using Microsoft.EntityFrameworkCore;
using Salon.DAL.Repository.Interface;
using Salon.Migrations;
using Salon.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.DAL.Repository.Implementation
{
    public class SalonServiceRepository : ISalonServiceRepository
    {
        private readonly SalonContext _context;
        public SalonServiceRepository(SalonContext context)
        {
            _context = context;
        }
        public async Task<List<SalonService>> GetServicesBySalonId(int salonId)
        {
            var salonDetails = await _context.Service.Where(x => x.SalonId == salonId).ToListAsync();
            return salonDetails;
        }

        public async Task<SalonService> GetServicesById(int id)
        {
            var salonDetails = await _context.Service.Where(x => x.Id == id).FirstOrDefaultAsync();
            return salonDetails;
        }


    }
}
