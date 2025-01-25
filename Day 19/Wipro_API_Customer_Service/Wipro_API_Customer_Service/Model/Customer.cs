using System.ComponentModel.DataAnnotations;

namespace Wipro_API_Customer_Service.Model
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public int CustomerAge { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
    }
}
