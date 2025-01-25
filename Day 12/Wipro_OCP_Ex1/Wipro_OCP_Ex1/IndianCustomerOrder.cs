using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_OCP_Ex1
{
    public class IndianCustomerOrder : CustomerOrder
    {
        public override void ProcessOrder()
        {
            Console.WriteLine("Processing your order in INR");
        }
    }
}
