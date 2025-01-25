using System;
using System.Collections.Generic;

namespace Wipro_Abstract_Day8_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Details> userList = new List<Details>();

            start:
            Console.WriteLine("Enter User ID: ");
            int userId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter User Name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter User Email: ");
            string userEmail = Console.ReadLine();
            Console.WriteLine("Enter User Contact");
            string userContact = Console.ReadLine();
            Console.WriteLine("Enter User City: ");
            string userCity = Console.ReadLine();
            Console.WriteLine("Enter User Gender: ");
            string userGender = Console.ReadLine();

            Details objDetails = new Details()
            {
                UserId = userId,
                UserName = userName,
                UserEmail = userEmail,
                UserContact = userContact,
                City = userCity,
                Gender = userGender
            };
            userList.Add(objDetails);

            foreach (var user in  userList)
            {
                Console.WriteLine($"===============================(User Details - {user.UserName})===============================");
                Console.WriteLine($"User ID: {user.UserId}   |   User Name: {user.UserName}");
                Console.WriteLine($"User Email: {user.UserEmail}   |   User Contact: {user.UserContact}");
                Console.WriteLine($"User City: {user.City}   |   User Gender: {user.Gender}");
                Console.WriteLine();
            }

            Console.ReadLine();
            goto start; 
        }
    }
}
