using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_OCP_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerShipper objCustomer1 = new IndianCustomerShipper();
            objCustomer1.ShipOrder();
            Console.WriteLine();

            CustomerShipper objCustomer2 = new JapaneseCustomerShipper();
            objCustomer2.ShipOrder();
            Console.WriteLine();

            CustomerShipper objCustomer3 = new CustomerShipper();
            objCustomer3.ShipOrder();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
