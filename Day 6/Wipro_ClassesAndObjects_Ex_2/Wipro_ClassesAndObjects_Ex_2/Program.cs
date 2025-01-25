using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wipro_ClassesAndObjects_Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            Person objPerson = new Person();

            Console.WriteLine("Enter person's Id: ");
            objPerson.personId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter person's name: ");
            objPerson.personName = Console.ReadLine();

            Console.WriteLine("Enter person's age: ");
            objPerson.personAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter person's address: ");
            objPerson.personAddress = Console.ReadLine();

            Console.WriteLine("Enter person's email: ");
            objPerson.personEmail = Console.ReadLine();

            Console.WriteLine("Enter person's phone number: ");
            objPerson.personPhone = Console.ReadLine();

            Console.WriteLine("================Person Information================");
            Console.WriteLine($"Person ID: {objPerson.personId}|   Person Name: {objPerson.personName}|" + "   " +
                $"Person Age: {objPerson.personAge}|   Person Address: {objPerson.personAddress}|" + "   " +
                $"Person Email: {objPerson.personEmail}|   Person Phone Number: {objPerson.personPhone}|");

            Console.ReadLine();
            goto start;
        }
    }

    public class Person
    {
        public int personId;
        public string personName;
        public int personAge;
        public string personAddress;
        public string personEmail;
        public string personPhone;
    }
}
