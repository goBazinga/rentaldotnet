using Microsoft.EntityFrameworkCore;
using RentalPlatform.Data.Model;

namespace RentalPlatform.Data
{
    public class RentalDBContext : DbContext
    {
        public RentalDBContext(DbContextOptions<RentalDBContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}