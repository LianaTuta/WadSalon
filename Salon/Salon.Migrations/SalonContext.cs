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
                new SalonModel { Id = 1, Name = "Serene Haven Salon & Spa", ImagePath = "salon1.jpg", Description = "Welcome to Serene Haven Salon & Spa, where tranquility meets transformation. Nestled in the heart of Craiova, our haven offers a serene escape from the hustle and bustle of everyday life. Step into our luxurious sanctuary and embark on a journey of self-care and rejuvenation.\r\n\r\nOur team of skilled professionals is dedicated to providing unparalleled service tailored to your unique needs. Whether you're craving a glamorous makeover, a relaxing massage, or a rejuvenating facial, we have a wide range of services to pamper you from head to toe.", Address = "Address 1" },
                new SalonModel { Id = 2, Name = "Enchanted Beauty Lounge", ImagePath = "salon1.jpg", Description = "Welcome to Enchanted Elegance Beauty Lounge, where every visit is a magical experience. Step into our luxurious sanctuary and immerse yourself in a world of enchantment, where beauty meets elegance.\r\n\r\nOur talented team of professionals is dedicated to providing you with top-notch service, tailored to your unique needs and desires. Whether you're seeking a glamorous makeover, a relaxing spa treatment, or expertly styled hair, we have everything you need to enhance your natural beauty and leave you feeling radiant.\r\n\r\nAt Enchanted Elegance, we believe in using only the finest quality products, carefully selected to deliver exceptional results. From luxurious skincare to premium hair care, every detail is designed to pamper you from head to toe and make you feel like royalty.", Address = "Address 2" },
                new SalonModel { Id = 3, Name = "Beauty Salon with Name 3", ImagePath = "salon1.jpg", Description = "Description 3", Address = "Address 3" },
                new SalonModel { Id = 4, Name = "Beauty Salon with Name 4", ImagePath = "salon1.jpg", Description = "Description 4", Address = "Address 4" }

            );
            modelBuilder.Entity<SalonService>().HasData(
                  new SalonService { Id = 1, Name = "Gel Nails", SalonId = 3, Description = "Description nails" },
                  new SalonService { Id = 2, Name = "Hair Treatment", SalonId = 4, Description = "Descriptions hair" },
                  new SalonService { Id = 3, Name = "Haircut", SalonId = 4, Description = "Description hair" },
                  new SalonService { Id = 4, Name = "Gel Nails", SalonId = 4, Description = "Description gel nails" },
                  new SalonService { Id = 5, Name = "Serenity Signature Massage", SalonId = 1, Description = "Relax and unwind with our signature massage, tailored to soothe muscles and promote deep relaxation." },
                  new SalonService { Id = 6, Name = "Radiance Renewal Facial", SalonId = 1, Description = "Revive your skin's natural glow with our customized facial, leaving you with a luminous complexion" },
                  new SalonService { Id = 7, Name = "Fairy Tale Manicure/Pedicure", SalonId = 2, Description = "Pamper your hands and feet with our Fairy Tale Manicure/Pedicure, complete with luxurious treatments and enchanting nail art." },
                  new SalonService { Id = 8, Name = "Natural Makeup Application", SalonId = 2, Description = "Enhance your features with our Natural Makeup Application, perfect for a subtle yet polished look." },
                  new SalonService { Id = 9, Name = "Nourishing Hair Treatment", SalonId = 2, Description = "Nourish your hair with our Nourishing Hair Treatment, restoring health and shine to your locks." }
                  );
        }

    }
}
