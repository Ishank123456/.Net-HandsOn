
namespace Wipro_Properties_GetSet_Ex2
{
    public class Customer
    {
        int customerId;
        string customerName;
        string customerGender;

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public string CustomerGender
        {
            get { return customerGender; }
            set { customerGender = value; }
        }

        public string CustomerAddress
        {
            get; set;
        }
        public string CustomerEmail
        {
            get; set;
        }
        public string CustomerContact
        {
            get; set;
        }
    }
}
