using System;

namespace Wipro_Hybrid_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================Parent Information================");
            Parent objParent = new Parent();
            objParent.ParentShowInformation();

            Console.WriteLine("================Child One Information================");
            Child1 objChild1 = new Child1();
            objChild1.ParentShowInformation();
            objChild1.Child1ShowInformation();

            Console.WriteLine("================Child Two Information================");
            Child2 objChild2 = new Child2();
            objChild2.ParentShowInformation();
            objChild2.Child2ShowInformation();

            Console.WriteLine("================Sub-Child One Information================");
            SubChild1 objSubChild1 = new SubChild1();
            objSubChild1.ParentShowInformation();
            objSubChild1.Child1ShowInformation();
            objSubChild1.SubChild1ShowInformation();

            Console.WriteLine("================Sub-Child Two Information================");
            SubChild2 objSubChild2 = new SubChild2();
            objSubChild2.ParentShowInformation();
            objSubChild2.Child2ShowInformation();
            objSubChild2.SubChild2ShowInformation();

            Console.ReadLine();
        }
    }
    public class Parent
    {
        public void ParentShowInformation()
        {
            Console.WriteLine("Parent Information Display");
        }
    }
    public class Child1 : Parent
    {
        public void Child1ShowInformation()
        {
            Console.WriteLine("Child One Information Display");
        }
    }
    public class Child2: Parent
    {
        public void Child2ShowInformation()
        {
            Console.WriteLine("Child Two Information Display");
        }
    }
    public class SubChild1 : Child1
    {
        public void SubChild1ShowInformation()
        {
            Console.WriteLine("Sub-Child One Information Display");
        }
    }
    public class SubChild2 : Child2
    {
        public void SubChild2ShowInformation()
        {
            Console.WriteLine("Sub-Child Two Information Display");
        }
    }
}
