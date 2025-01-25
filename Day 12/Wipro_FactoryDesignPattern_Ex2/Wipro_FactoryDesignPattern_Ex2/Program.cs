using System;

namespace Wipro_FactoryDesignPattern_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory objFactory = new Factory();

            Console.WriteLine("===================Strawberry===================");
            IIceCream objIceCream1 = objFactory.GetObjects(1);
            objIceCream1.Display();

            Console.WriteLine("===================Chocolate===================");
            IIceCream objIceCream2 = objFactory.GetObjects(2);
            objIceCream2.Display();

            Console.WriteLine("===================Vanilla===================");
            IIceCream objIceCream3 = objFactory.GetObjects(3);
            objIceCream3.Display();

            Console.ReadLine();
        }
    }
}
