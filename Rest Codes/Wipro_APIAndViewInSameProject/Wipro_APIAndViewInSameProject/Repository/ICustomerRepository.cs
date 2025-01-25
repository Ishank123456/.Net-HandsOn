using Wipro_APIAndViewInSameProject.Models;

namespace Wipro_APIAndViewInSameProject.Repository
{
	public interface ICustomerRepository
	{
		IEnumerable<Customer> GetAllCustomers();
		Customer GetCustomer(int id);
		int CreateCustomer(Customer customer);
		int UpdateCustomer(Customer customer);
		int DeleteCustomer(Customer customer);
	}
}
