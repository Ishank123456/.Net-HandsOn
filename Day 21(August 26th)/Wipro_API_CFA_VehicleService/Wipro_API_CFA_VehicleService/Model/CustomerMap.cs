using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Wipro_API_CFA_VehicleService.Model
{
    public class CustomerMap
    {
        public CustomerMap(EntityTypeBuilder<Customer> entityTypeBuilderCustomer)
        {
            entityTypeBuilderCustomer.HasKey(cust => cust.CustomerId);
            entityTypeBuilderCustomer.Property(cust => cust.CustomerId).IsRequired();
            entityTypeBuilderCustomer.Property(cust => cust.CustomerName).IsRequired();
            entityTypeBuilderCustomer.Property(cust => cust.CustomerAddress).IsRequired();
            entityTypeBuilderCustomer.Property(cust => cust.CustomerMobileNo).IsRequired();
            entityTypeBuilderCustomer.Property(cust => cust.CustomerMobileNo).HasMaxLength(20);
        }
    }
}
