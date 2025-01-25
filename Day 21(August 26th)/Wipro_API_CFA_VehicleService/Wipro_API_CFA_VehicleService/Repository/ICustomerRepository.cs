using Wipro_API_CFA_VehicleService.Model;

namespace Wipro_API_CFA_VehicleService.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer SearchCustomer(int vehicleId);
        Customer CreateCustomer(Customer customer);
        Customer UpdateCustomerInfo(Customer customer);
        bool DeleteCustomerInfo(int custId);
    }
}
