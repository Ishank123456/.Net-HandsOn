using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_OCP_Ex1
{
    public class JapaneseCustomerOrder : CustomerOrder
    {
        public override void ProcessOrder()
        {
            Console.WriteLine("Processing your order in Japanese YEN");
        }
    }
}
