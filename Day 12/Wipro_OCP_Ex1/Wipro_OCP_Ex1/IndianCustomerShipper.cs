using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_OCP_Ex1
{
    public class IndianCustomerShipper : CustomerShipper
    {
        public override void ShipOrder()
        {
            DataAccess objDataAccess = new DataAccess();
            objDataAccess.GetProducts();
            CustomerOrder objIndianCustomerOrder = new IndianCustomerOrder();
            objIndianCustomerOrder.ProcessOrder();

            Console.WriteLine("Shipping to Delhi via Train");
        }
    }
}
