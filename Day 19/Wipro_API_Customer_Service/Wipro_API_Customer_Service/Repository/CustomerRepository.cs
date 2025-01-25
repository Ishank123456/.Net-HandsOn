using Wipro_API_Customer_Service.Model;
using Wipro_API_Customer_Service.EntityFramework;

namespace Wipro_API_Customer_Service.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public CustomerRepository(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }
        public int CreateCustomer(Customer customer)
        {
            applicationDbContext.Add(customer);
            return applicationDbContext.SaveChanges();
        }

        public int DeleteCustomer(Customer customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            applicationDbContext.Customers.Remove(customer); //Removing from local memory
            return applicationDbContext.SaveChanges();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return applicationDbContext.Customers.ToList();
        }

        public Customer SearchCustomer(int id)
        {
            return applicationDbContext.Customers.SingleOrDefault(t => t.CustomerId == id);
        }

        public int UpdateCustomer(Customer customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            applicationDbContext.Customers.Update(customer);
            return applicationDbContext.SaveChanges();
        }
    }
}
