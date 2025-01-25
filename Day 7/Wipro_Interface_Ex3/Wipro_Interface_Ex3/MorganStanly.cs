using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Interface_Ex3
{
    public class MorganStanly : IWipro
    {
        public string GetFullName(string fname, string lname)
        {
            return fname + " " + lname;
        }

        public void Display(string str)
        {
            Console.WriteLine(str);
        }
    }
}
