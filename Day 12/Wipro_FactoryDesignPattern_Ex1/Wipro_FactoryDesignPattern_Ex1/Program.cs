using System;

namespace Wipro_FactoryDesignPattern_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory objFactory = new Factory();
            IBase obj1 = objFactory.GetObject(1);
            obj1.Display();
            IBase obj2 = objFactory.GetObject(2);
            obj2.Display();

            Console.ReadLine();
        }
    }
}
