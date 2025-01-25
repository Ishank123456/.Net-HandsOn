using Wipro_API_Customer_Service.Model;

namespace Wipro_API_Customer_Service.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        Customer SearchCustomer(int id);
        
        int UpdateCustomer(Customer customer);
        int CreateCustomer(Customer customer);
        int DeleteCustomer(Customer customer);
    }
}
