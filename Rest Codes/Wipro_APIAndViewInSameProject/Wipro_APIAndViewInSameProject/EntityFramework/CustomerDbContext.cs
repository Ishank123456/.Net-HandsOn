using Microsoft.EntityFrameworkCore;
using Wipro_APIAndViewInSameProject.Models;

namespace Wipro_APIAndViewInSameProject.EntityFramework
{
	public class CustomerDbContext : DbContext
	{
		public CustomerDbContext(DbContextOptions options) : base(options) { }

		public DbSet<Customer> Customers { get; set; }
	}
}
