using Wipro_DFA_API_ECommerceService.Models;

namespace Wipro_DFA_API_ECommerceService.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer SearchCustomer(int custId);
        Customer CreateCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
        bool DeleteCustomer(int custId);
    }
}
