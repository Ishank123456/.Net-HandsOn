using Microsoft.EntityFrameworkCore;
using Practice_APIWithView_MVC_Login.Models;

namespace Practice_APIWithView_MVC_Login.EntityFramework
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options) { }

        public DbSet<UserProfile> Profiles { get; set; }
    }
}
