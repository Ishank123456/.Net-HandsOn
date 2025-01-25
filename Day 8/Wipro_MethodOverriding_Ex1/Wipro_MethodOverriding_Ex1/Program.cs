using System;

namespace Wipro_MethodOverriding_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent objParent = new Parent();
            objParent.Display();

            Child objChild = new Child();
            objChild.Display();

            Parent objParent1 = new Child();
            objParent1.Display();

            Console.ReadLine();
        }
    }
    public class Parent
    {
        public virtual void Display()
        {
            Console.WriteLine("Parent Method Called");
        }
    }
    public class Child : Parent
    {
        public override void Display()
        {
            Console.WriteLine("Child Method Called");
        }
    }
}
