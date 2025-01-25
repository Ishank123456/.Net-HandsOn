using System;

namespace Wipro_Reflections_Ex2
{
    public class Student
    {
        public int studentRollNo { get; set; }
        public string studentName { get; set; }
        public int studentAge { get; set; }

        public Student()
        {
            studentRollNo = 1;
            studentName = "Rahul";
            studentAge = 24;
        }
        public Student(int _studentRollNo, string _studentName, int _studentAge)
        {
            studentRollNo = _studentRollNo;
            studentName = _studentName;
            studentAge = _studentAge;
        }
        public void Display()
        {
            Console.WriteLine($"Student Name: {studentName}   |   Student Roll No: {studentRollNo}   |   " +
                              $"Student Age: {studentAge}");
        }
    }
}
