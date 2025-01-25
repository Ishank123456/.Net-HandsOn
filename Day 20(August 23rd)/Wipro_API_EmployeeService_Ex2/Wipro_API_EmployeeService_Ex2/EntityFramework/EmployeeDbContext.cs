using Microsoft.EntityFrameworkCore;
using Wipro_API_EmployeeService_Ex2.Model;

namespace Wipro_API_EmployeeService_Ex2.EntityFramework
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
