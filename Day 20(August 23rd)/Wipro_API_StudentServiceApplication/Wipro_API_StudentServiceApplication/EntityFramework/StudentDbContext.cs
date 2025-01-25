using Microsoft.EntityFrameworkCore;
using Wipro_API_StudentServiceApplication.Model;

namespace Wipro_API_StudentServiceApplication.EntityFramework
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
