using Wipro_ViewModel.Models;

namespace Wipro_ViewModel.ViewModel
{
    public class CustomerDetailsViewModel
    {
        public Customer Customer { get; set; }
        public List<AddressCustomer> LstCustomerAddress { get; set; }
    }
}
