using System;

namespace Wipro_Reflections_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================String=================");
            Type t = typeof(string);
            Console.WriteLine($"Name: {t.Name}");
            Console.WriteLine($"Full Name: {t.FullName}");
            Console.WriteLine($"Namespace: {t.Namespace}");
            Console.WriteLine($"Base Type: {t.BaseType}");
            Console.WriteLine($"Assembly: {t.Assembly}");
            Console.WriteLine($"Assembly Name: {t.AssemblyQualifiedName}");

            Console.WriteLine("=================Integer=================");
            Type t1 = typeof(int);
            Console.WriteLine($"Name: {t1.Name}");
            Console.WriteLine($"Full Name: {t1.FullName}");
            Console.WriteLine($"Namespace: {t1.Namespace}");
            Console.WriteLine($"Base Type: {t1.BaseType}");
            Console.WriteLine($"Assembly: {t1.Assembly}");
            Console.WriteLine($"Assembly Name: {t1.AssemblyQualifiedName}");

            Console.WriteLine("=================Boolean=================");
            Type t2 = typeof(bool);
            Console.WriteLine($"Name: {t2.Name}");
            Console.WriteLine($"Full Name: {t2.FullName}");
            Console.WriteLine($"Namespace: {t2.Namespace}");
            Console.WriteLine($"Base Type: {t2.BaseType}");
            Console.WriteLine($"Assembly: {t2.Assembly}");
            Console.WriteLine($"Assembly Name: {t2.AssemblyQualifiedName}");

            Console.ReadLine();
        }
    }
}
