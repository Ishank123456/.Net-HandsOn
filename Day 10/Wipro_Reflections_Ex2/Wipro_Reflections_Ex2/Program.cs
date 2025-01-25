using System;
using System.Reflection;

namespace Wipro_Reflections_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare Instance of Class Assembly
            //Call the GetExecutingAssembly method to load the current assembly
            Assembly assembly = Assembly.GetExecutingAssembly();
            //Array to store the types of the assembly
            Type[] types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine($"Classes: {type.Name}");
                Console.WriteLine("----------------------------------------------------------------");

                //Array to store methods
                MethodInfo[] methods = type.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine($"Methods: {method.Name}");
                    Console.WriteLine($"Method Return Type: {method.ReturnType}");
                    Console.WriteLine($"Method Parameters: {method.ReturnParameter}");
                    Console.WriteLine($"Method Class Name: {method.DeclaringType}");

                    //Array to store parameters
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var param in parameters)
                    {
                        Console.WriteLine($"Parameters: {param.Name}");
                        Console.WriteLine($"Parameter Type: {param.ParameterType}");
                        Console.WriteLine($"Parameter Member: {param.Member}");
                        Console.WriteLine($"Parameter Default Value: {param.HasDefaultValue}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
