using System;
using Wipro_Assesment_dll;

namespace Wipro_Assesment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================Arithmetic============================");
            Arithmetic objArithmetic = new Arithmetic();

            Console.WriteLine("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The Addition is: {objArithmetic.Add(num1, num2)}");
            Console.WriteLine($"The Subtraction is: {objArithmetic.Subtract(num1, num2)}");
            Console.WriteLine($"The Multiplication is: {objArithmetic.Multiply(num1, num2)}");
            Console.WriteLine($"The Division is: {objArithmetic.Divide(num1, num2)}");
            Console.WriteLine();


            Console.WriteLine("============================Area============================");
            Area objArea = new Area();
            Console.WriteLine();

            Console.WriteLine("==============Area of Rectangle==============");
            Console.WriteLine("Enter the length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The Area of Rectangle is: {objArea.AreaRectangle(length, width)}");
            Console.WriteLine();

            Console.WriteLine("==============Area of Square==============");
            Console.WriteLine("Enter length of the side: ");
            double side = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The Area of Square is: {objArea.AreaSquare(side)}");
            Console.WriteLine();

            Console.WriteLine("==============Area of Circle==============");
            Console.WriteLine("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The Area of Circle is: {objArea.AreaCircle(radius)}");
            Console.WriteLine();

            Console.WriteLine("==============Area of Triangle==============");
            Console.WriteLine("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter base length: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The Area of Triangle is: {objArea.AreaTriangle(height, baseLength)}");
            Console.WriteLine();

            Console.WriteLine("============================String Operations============================");
            GetFullName objGetFullName = new GetFullName();
            Console.WriteLine("Enter first name: ");
            objGetFullName.firstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            objGetFullName.lastName = Console.ReadLine();

            Console.WriteLine($"The Name is {objGetFullName.firstName} {objGetFullName.lastName}");
            Console.WriteLine();

            Console.WriteLine("============================Customer Information============================");
            Console.WriteLine();

            Console.WriteLine("==============Customer One==============");
            Customer objCustomer1 = new Customer();
            Console.WriteLine("Enter first customer id: ");
            objCustomer1.customerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first customer name: ");
            objCustomer1.customerName = Console.ReadLine();
            Console.WriteLine("Enter first customer address: ");
            objCustomer1.customerAddress = Console.ReadLine();
            Console.WriteLine("Enter first customer email: ");
            objCustomer1.customerEmail = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("==============Customer Two==============");
            Customer objCustomer2 = new Customer();
            Console.WriteLine("Enter second customer id: ");
            objCustomer2.customerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second customer name: ");
            objCustomer2.customerName = Console.ReadLine();
            Console.WriteLine("Enter second customer address: ");
            objCustomer2.customerAddress = Console.ReadLine();
            Console.WriteLine("Enter second customer email: ");
            objCustomer2.customerEmail = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("==============Customer Information Table==============");
            Console.WriteLine($"Customer ID: {objCustomer1.customerId}|   Customer Name: {objCustomer1.customerName}|" + "   " +
                              $"Customer Address: {objCustomer1.customerAddress}|   Customer Email: {objCustomer1.customerEmail}");

            Console.WriteLine($"Customer ID: {objCustomer2.customerId}|   Customer Name: {objCustomer2.customerName}|" + "   " +
                              $"Customer Address: {objCustomer2.customerAddress}|   Customer Email: {objCustomer2.customerEmail}");

            Console.ReadLine();
        }
    }
}
