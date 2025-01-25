using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ECommerceApplication
{
    public class OrderTableInfo
    {
        public int OrderId { get; set; }
        public int CustomerId {  get; set; }
        public string OrderProducts { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
