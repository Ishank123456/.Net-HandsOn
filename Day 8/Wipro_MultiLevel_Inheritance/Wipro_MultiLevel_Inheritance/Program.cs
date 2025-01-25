using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_MultiLevel_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================Grand Parent Method===================");
            GrandParent objGrandParent = new GrandParent();
            objGrandParent.Hello();

            Console.WriteLine("===================Parent Method===================");
            Parent objParent = new Parent();
            objParent.Hello();
            objParent.Display();

            Console.WriteLine("===================Child Method===================");
            Child objChild = new Child();
            objChild.Hello();
            objChild.Display();
            objChild.Print();

            Console.ReadLine();
        }
    }
    public class GrandParent
    {
        public void Hello()
        {
            Console.WriteLine("Grand Parent method is called");
        }
    }
    public class Parent : GrandParent
    {
        public void Display()
        {
            Console.WriteLine("Parent method is called");
        }
    }
    public class Child : Parent
    {
        public void Print()
        {
            Console.WriteLine("Child method is called");
        }
    }
}
