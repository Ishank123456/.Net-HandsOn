using Microsoft.EntityFrameworkCore;
using Wipro_HealthManagementSystemCFA.Models;

namespace Wipro_HealthManagementSystemCFA.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
    }
}
