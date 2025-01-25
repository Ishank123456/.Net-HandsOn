using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ListCollection_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> lstDepartment = new List<Department>();

            Department objDepartment1 = new Department()
            {
                deptID = 101,
                deptName = "IT"
            };
            lstDepartment.Add(objDepartment1);

            Department objDepartment2 = new Department()
            {
                deptID = 102,
                deptName = "HR"
            };
            lstDepartment.Add(objDepartment2);

            Department objDepartment3 = new Department()
            {
                deptID = 103,
                deptName = "Sales"
            };
            lstDepartment.Add(objDepartment3);

            Console.WriteLine("========================Department Details========================");
            foreach (Department objDepartment in lstDepartment)
            {
                Console.WriteLine($"Department ID::  {objDepartment.deptID}   ||   Department Name::  {objDepartment.deptName}");
            }
            Console.ReadLine();
        }
    }
}
