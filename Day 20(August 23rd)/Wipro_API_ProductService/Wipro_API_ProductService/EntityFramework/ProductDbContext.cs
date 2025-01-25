using Microsoft.EntityFrameworkCore;
using Wipro_API_ProductService.Model;

namespace Wipro_API_ProductService.EntityFramework
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
