using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Interface_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================Genpact===================");
            Genpact objGenpact = new Genpact();

            Console.WriteLine("Enter first name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter what to display: ");
            string display = Console.ReadLine();

            string name = objGenpact.GetFullName(fname, lname);
            Console.WriteLine($"Full Name is {name}");
            objGenpact.Display(display);
            Console.WriteLine(objGenpact.Add(20, 10));


            Console.WriteLine("===================Infosys===================");
            Infosys objInfosys = new Infosys();
            Console.WriteLine("Enter first name: ");
            string fname1 = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string lname1 = Console.ReadLine();
            Console.WriteLine("Enter what to display: ");
            string display1 = Console.ReadLine();

            string name1 = objInfosys.GetFullName(fname1, lname1);
            Console.WriteLine($"Full Name is {name1}");
            objInfosys.Display(display1);


            Console.WriteLine("===================MorganStanly===================");
            MorganStanly objMorganStanly = new MorganStanly();
            Console.WriteLine("Enter first name: ");
            string fname2 = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string lname2 = Console.ReadLine();
            Console.WriteLine("Enter what to display: ");
            string display2 = Console.ReadLine();

            string name2 = objMorganStanly.GetFullName(fname2, lname2);
            Console.WriteLine($"Full Name is {name2}");
            objMorganStanly.Display(display2);

            Console.ReadLine();
        }
    }
}
