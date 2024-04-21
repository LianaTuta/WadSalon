using Microsoft.EntityFrameworkCore;
using Salon.Model.Models;

namespace Salon.Migrations
{
    public class SalonContext : DbContext
    {
        public SalonContext(DbContextOptions<SalonContext> options)
            : base(options)
        {

        }
        public DbSet<SalonModel> Salon { get; set; }
        public DbSet<SalonService> Service { get; set; }
        public DbSet<Appoinment> Appoinment { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<UserAddress> UserAddress { get; set; }
        public DbSet<UserLogin> UserLogin { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalonModel>().HasData(
                new SalonModel { Id = 1, Name = "Beauty Salon 1", ImagePath = "salon1.jpg", Description = "Description 1", Address = "Address 1" },
                new SalonModel { Id = 2, Name = "Beauty Salon 2", ImagePath = "salon1.jpg", Description = "Description 2", Address = "Address 2" },
                new SalonModel { Id = 3, Name = "Beauty Salon 3", ImagePath = "salon1.jpg", Description = "Description 3", Address = "Address 3" },
                new SalonModel { Id = 4, Name = "Beauty Salon 4", ImagePath = "salon1.jpg", Description = "Description 4", Address = "Address 4" }

            );
            modelBuilder.Entity<SalonService>().HasData(
                  new SalonService { Id = 1, Name = "Gel Nails", SalonId = 1, Description = "Description nails" },
                  new SalonService { Id = 2, Name = "Hair Treatment", SalonId = 1, Description = "Descriptions hair" },
                  new SalonService { Id = 3, Name = "Haircut", SalonId = 1, Description = "Description hair" },
                  new SalonService { Id = 4, Name = "Gel Nails", SalonId = 1, Description = "Description facials" }
            );
        }

    }
}
