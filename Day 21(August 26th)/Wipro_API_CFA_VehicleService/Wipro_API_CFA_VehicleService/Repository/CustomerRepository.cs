using Wipro_API_CFA_VehicleService.EntityFramework;
using Wipro_API_CFA_VehicleService.Model;

namespace Wipro_API_CFA_VehicleService.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly VehicleDbContext vehicleDbContext;
        public CustomerRepository(VehicleDbContext _vehicleDbContext)
        {
            vehicleDbContext = _vehicleDbContext;
        }

        public Customer CreateCustomer(Customer customer)
        {
            var result = vehicleDbContext.Customers.Add(customer);
            vehicleDbContext.SaveChanges();
            return result.Entity;
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return vehicleDbContext.Customers.ToList();
        }
        public Customer SearchCustomer(int custId)
        {
            return vehicleDbContext.Customers.SingleOrDefault(c => c.CustomerId == custId);
        }
        public Customer UpdateCustomerInfo(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            var result = vehicleDbContext.Customers.Update(customer);
            vehicleDbContext.SaveChanges();
            return result.Entity;
        }
        public bool DeleteCustomerInfo(int custId)
        {
            var filterCustomerData = vehicleDbContext.Customers.Where(c => c.CustomerId == custId).FirstOrDefault();
            var result = vehicleDbContext.Customers.Remove(filterCustomerData);
            vehicleDbContext.SaveChanges();
            return result != null ? true : false;
        }
    }
}
