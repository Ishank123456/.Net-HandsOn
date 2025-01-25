using Wipro_DFA_API_E_CommerceApplication.EntityFramework;
using Wipro_DFA_API_E_CommerceApplication.Models;

namespace Wipro_DFA_API_E_CommerceApplication.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly WiproDfa26082024Context customerDbContext;
        public CustomerRepository(WiproDfa26082024Context _customerDbContext)
        {
            customerDbContext = _customerDbContext;
        }

        public Customer CreateCustomer(Customer customer)
        {
            var result = customerDbContext.Customers.Add(customer);
            customerDbContext.SaveChanges();
            return result.Entity;
        }

        public bool DeleteCustomer(int custId)
        {
            var filterCustomerData = customerDbContext.Customers.Where(c => c.CustomerId == custId).FirstOrDefault();
            var result = customerDbContext.Customers.Remove(filterCustomerData);
            customerDbContext.SaveChanges();
            return result != null ? true : false;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return customerDbContext.Customers.ToList();
        }

        public Customer SearchCustomer(int custId)
        {
            return customerDbContext.Customers.SingleOrDefault(c => c.CustomerId == custId);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            var result = customerDbContext.Customers.Update(customer);
            customerDbContext.SaveChanges();
            return result.Entity;
        }
    }
}
