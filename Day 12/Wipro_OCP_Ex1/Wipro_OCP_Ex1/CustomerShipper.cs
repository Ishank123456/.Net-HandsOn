using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_OCP_Ex1
{
    public class CustomerShipper
    {
        public virtual void ShipOrder()
        {
            DataAccess objDataAccess = new DataAccess();
            objDataAccess.GetProducts();
            CustomerOrder objCustomerOrder = new CustomerOrder();
            objCustomerOrder.ProcessOrder();
            
            Console.WriteLine("Shipping to NY via Flight");
        }
    }
}
