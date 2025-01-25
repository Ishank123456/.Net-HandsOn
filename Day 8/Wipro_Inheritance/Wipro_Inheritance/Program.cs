using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent objParent = new Parent();
            objParent.Display();

            Child objChild = new Child();
            objChild.Display();
            objChild.Show();

            Console.ReadLine();
        }
    }
    public class Parent
    {
        public void Display()
        {
            Console.WriteLine("Parent Display method called");
        }
    }
    public class Child : Parent
    {
        public void Show()
        {
            Console.WriteLine("Child Show method called");
        }
    }
}
