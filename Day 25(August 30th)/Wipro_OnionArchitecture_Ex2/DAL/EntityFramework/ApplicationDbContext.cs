using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new DeptMap(modelBuilder.Entity<Department>());
            new EmpMap(modelBuilder.Entity<Employee>());
        }
    }
}
