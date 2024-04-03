using Microsoft.EntityFrameworkCore;
using Salon.Models;

namespace Salon.DAL
{
    public class SalonContext : DbContext
    {
        public SalonContext(DbContextOptions<SalonContext> options)
            : base(options)
        {

        }
        public DbSet<Models.Salon> Salon { get; set; }
        public DbSet<SalonService> Service{ get; set; }
        public DbSet<Appoinment> Appoinment { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<UserAddress> UserAddress { get; set; }
        public DbSet<UserPassword> UserPassword { get; set; }

    }
}
