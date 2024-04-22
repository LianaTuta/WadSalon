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
    public class AppoinmentRepository : IAppointmentRepository
    {
        private readonly SalonContext _context;
        public AppoinmentRepository(SalonContext context)
        {
            _context = context;
        }
        public async Task SaveAppointment(Appoinment appoinment)
        {
            await _context.Appoinment.AddAsync(appoinment);
            await _context.SaveChangesAsync();
        }
    }
}
