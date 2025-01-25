using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_SealedClass_Ex2
{
    public sealed class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }

        public void Display()
        {
            Console.WriteLine("Displaying");
        }
    }
    public class C1 : Customer
    {
        public void Display()
        {
            Console.WriteLine("Not Displaying");
        }
    }
}
