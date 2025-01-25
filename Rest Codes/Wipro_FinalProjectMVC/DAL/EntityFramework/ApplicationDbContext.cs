using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UserLogin> UserLogin { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserMap(modelBuilder.Entity<User>());
            new UserProfileMap(modelBuilder.Entity<UserProfile>());
            new CategoryMap(modelBuilder.Entity<Category>());
        }
    }
}
