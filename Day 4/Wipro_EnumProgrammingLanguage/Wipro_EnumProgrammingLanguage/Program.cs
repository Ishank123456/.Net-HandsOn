using System;

namespace Wipro_EnumProgrammingLanguage
{
    internal class Program
    {
        public enum Programming { Dotnet, AWS, C, MVC, Angular, DotNetCore, Azure}
        static void Main(string[] args)
        {
            int dotnet = (int)Programming.Dotnet;
            int aws = (int)Programming.AWS;
            int c = (int)Programming.C;
            int mvc = (int)Programming.MVC;
            int ang = (int)Programming.Angular;
            int dotnetcore = (int)Programming.DotNetCore;
            int azure = (int)Programming.Azure;

            Console.WriteLine("===============Values of the Enum===============");
            foreach (string s in Enum.GetNames(typeof(Programming)))
            {
                Console.WriteLine($"The Program would be: {s}");
            }

            Console.WriteLine("===============Index and their Values===============");
            string str = Enum.GetName(typeof(Programming), dotnet);
            Console.WriteLine($"Index: {dotnet}      Value: {str}");

            str = Enum.GetName(typeof(Programming), aws);
            Console.WriteLine($"Index: {aws}      Value: {str}");

            str = Enum.GetName(typeof(Programming), c);
            Console.WriteLine($"Index: {c}      Value: {str}");

            str = Enum.GetName(typeof(Programming), mvc);
            Console.WriteLine($"Index: {mvc}      Value: {str}");

            str = Enum.GetName(typeof(Programming), ang);
            Console.WriteLine($"Index: {ang}      Value: {str}");

            str = Enum.GetName(typeof(Programming), dotnetcore);
            Console.WriteLine($"Index: {dotnetcore}      Value: {str}");

            str = Enum.GetName(typeof(Programming), azure);
            Console.WriteLine($"Index: {azure}      Value: {str}");

            Console.ReadLine();
        }
    }
}
