using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ListCollection_Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> lstStudents = new List<Student>();

            Student objStudent1 = new Student()
            {
                StudentId = 101,
                StudentName = "Rahul",
                StudentAddress = "India",
                StudentEmail = "rahul987@gmail.com",
                StudentContact = "+91-8976583687"
            };
            Student objStudent2 = new Student()
            {
                StudentId = 102,
                StudentName = "Subham",
                StudentAddress = "India",
                StudentEmail = "sc021@gmail.com",
                StudentContact = "+91-7384741470"
            };
            Student objStudent3 = new Student()
            {
                StudentId = 103,
                StudentName = "Emma",
                StudentAddress = "USA",
                StudentEmail = "emma875@gmail.com",
                StudentContact = "+1-0987583687"
            };
            lstStudents.Add(objStudent1);
            lstStudents.Add(objStudent2);
            lstStudents.Add(objStudent3);

            List<Teacher> lstTeachers = new List<Teacher>();

            Teacher objTeacher1 = new Teacher()
            {
                TeacherId = 10,
                TeacherName = "Sourav",
                TeacherAddress = "India",
                TeacherEmail = "sourav908@gmail.com",
                TeacherContact = "+91-9845725885"
            };
            objTeacher1.lstStudent = lstStudents;

            Teacher objTeacher2 = new Teacher()
            {
                TeacherId = 11,
                TeacherName = "Animesh",
                TeacherAddress = "India",
                TeacherEmail = "animesh598@gmail.com",
                TeacherContact = "+91-8654325885"
            };
            objTeacher2.lstStudent = lstStudents;

            Teacher objTeacher3 = new Teacher()
            {
                TeacherId = 12,
                TeacherName = "David",
                TeacherAddress = "USA",
                TeacherEmail = "david078@gmail.com",
                TeacherContact = "+1-5789725885"
            };
            objTeacher3.lstStudent = lstStudents;

            lstTeachers.Add(objTeacher1);
            lstTeachers.Add (objTeacher2);
            lstTeachers.Add (objTeacher3);

            
            List<Principal> lstPrincipals = new List<Principal>();

            Principal objPrincipal = new Principal()
            {
                PrincipalId = 1,
                PrincipalName = "Debasish"
            };
            objPrincipal.lstStudent = lstStudents;
            objPrincipal.lstTeacher = lstTeachers;

            lstPrincipals.Add(objPrincipal);

            Console.WriteLine("==============================Principal Details==============================");
            foreach (var principal in lstPrincipals)
            {
                Console.WriteLine($"Principal ID: {principal.PrincipalId}   |   Principal Name: {principal.PrincipalName}");
                Console.WriteLine();

                foreach (var teacher in principal.lstTeacher)
                {
                    Console.WriteLine($"==============================Assigned Teacher {teacher.TeacherName} Details==============================");
                    Console.WriteLine($"Teacher ID: {teacher.TeacherId}   |   Teacher Name: {teacher.TeacherName}   |" +
                                      $"Teacher Address: {teacher.TeacherAddress}   |   Teacher Email: {teacher.TeacherEmail}   |" +
                                      $"Teacher Contact: {teacher.TeacherContact}");
                    Console.WriteLine("==============================Assigned Student Details==============================");

                    foreach (var student in teacher.lstStudent)
                    {  
                        Console.WriteLine($"Student ID: {student.StudentId}   |   Student Name: {student.StudentName}   |" +
                                      $"Student Address: {student.StudentAddress}   |   Student Email: {student.StudentEmail}   |" +
                                      $"Student Contact: {student.StudentContact}");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
