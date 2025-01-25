using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Interface_Ex3
{
    public class Genpact : IWipro, IWiproForGenpact
    {
        public string GetFullName(string fname, string lname)
        {
            return fname + " " + lname;
        }

        public void Display(string str)
        {
            Console.WriteLine(str);
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
