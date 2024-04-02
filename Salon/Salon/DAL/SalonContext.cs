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
        public DbSet<SalonModel> Salons { get; set; }
        public DbSet<ProductModel> Products { get; set; }

    }
}
