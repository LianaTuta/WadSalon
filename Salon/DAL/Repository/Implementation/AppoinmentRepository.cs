using Microsoft.EntityFrameworkCore;
using Salon.DAL.Repository.Interface;
using Salon.Migrations;
using Salon.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public async Task<List<Appoinment>> GetAppointments(string userId)
        {
            return  _context.Appoinment.Where(a => a.AspNetUserId == userId).ToList();
        }

        public async Task UpdateAppointment(Appoinment appoinment)
        {
            _context.Appoinment.Update(appoinment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAppointment(Appoinment appoinment)
        {
            _context.Appoinment.Remove(appoinment);
            await _context.SaveChangesAsync();
        }
        public async Task<Appoinment?> GetAppointmentById(int id)
        {
            return _context.Appoinment.Where(a => a.Id == id).FirstOrDefault();
        }
    }
}
