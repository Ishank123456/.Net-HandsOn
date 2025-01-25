using System;

namespace Wipro_StaticConstructor_Ex2
{
    public class Company
    {
        public static int companyId;
        public static string companyName;
        public static string companyAddress;

        static Company()
        {
            Console.WriteLine("Static Constructor Called");
        }
    }
}
