using Microsoft.EntityFrameworkCore;
using Wipro_API_CFA_VehicleService.Model;

namespace Wipro_API_CFA_VehicleService.EntityFramework
{
    public class VehicleDbContext : DbContext
    {
        public VehicleDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new VehicleMap(modelBuilder.Entity<Vehicle>());
            new CustomerMap(modelBuilder.Entity<Customer>());
        }
    }
}
