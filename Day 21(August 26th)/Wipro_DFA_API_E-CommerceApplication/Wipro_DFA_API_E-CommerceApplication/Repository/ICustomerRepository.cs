using Wipro_DFA_API_E_CommerceApplication.Models;

namespace Wipro_DFA_API_E_CommerceApplication.Repository
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
