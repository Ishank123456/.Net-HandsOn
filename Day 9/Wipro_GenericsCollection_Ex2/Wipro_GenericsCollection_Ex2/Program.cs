using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_GenericsCollection_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent objParent = new Parent();
            objParent.Show<string>("Parent Called");
            objParent.Show<int>(45);
            objParent.Show<bool>(true);
            objParent.Show<char>('X');
            objParent.Show<decimal>(987467.9853m);

            Console.ReadLine();
        }
    }

    public class Parent
    {
        public void Show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
}
