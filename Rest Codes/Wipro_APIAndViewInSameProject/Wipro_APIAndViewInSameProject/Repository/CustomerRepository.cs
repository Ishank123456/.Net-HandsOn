using Wipro_APIAndViewInSameProject.EntityFramework;
using Wipro_APIAndViewInSameProject.Models;

namespace Wipro_APIAndViewInSameProject.Repository
{
	public class CustomerRepository : ICustomerRepository
	{
		private readonly CustomerDbContext customerDbContext;
		public CustomerRepository(CustomerDbContext _customerDbContext)
		{
			customerDbContext = _customerDbContext;
		}
		public int CreateCustomer(Customer customer)
		{
			customerDbContext.Customers.Add(customer);
			return customerDbContext.SaveChanges();
		}

		public int DeleteCustomer(Customer customer)
		{
			if(customer == null)
			{
				throw new ArgumentNullException("Entity Missing");
			}
			customerDbContext.Customers.Remove(customer);
			return customerDbContext.SaveChanges();
		}

		public IEnumerable<Customer> GetAllCustomers()
		{
			return customerDbContext.Customers.ToList();
		}

		public Customer GetCustomer(int id)
		{
			return customerDbContext.Customers.SingleOrDefault(c => c.CustomerId == id);
		}

		public int UpdateCustomer(Customer customer)
		{
			customerDbContext.Customers.Update(customer);
			return customerDbContext.SaveChanges();
		}
	}
}
