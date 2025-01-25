using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_OCP_Ex1
{
    public class JapaneseCustomerShipper : CustomerShipper
    {
        public override void ShipOrder()
        {
            DataAccess objDataAccess = new DataAccess();
            objDataAccess.GetProducts();
            CustomerOrder objJapaneseCustomerOrder = new JapaneseCustomerOrder();
            objJapaneseCustomerOrder.ProcessOrder();

            Console.WriteLine("Shipping to Tokyo via Ship");
        }
    }
}
