using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_SingleTypeInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher objTeacher = new Teacher();
            objTeacher.Teach();

            Student objStudent = new Student();
            objStudent.Teach();
            objStudent.Learn();

            Console.ReadLine();
        }
    }
    public class Teacher
    {
        public void Teach()
        {
            Console.WriteLine("Teacher teaches the student");
        }
    }
    public class Student : Teacher
    {
        public void Learn()
        {
            Console.WriteLine("Students are learning from Teachers");
        }
    }
}
