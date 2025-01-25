using System;
using System.Collections.Generic;

namespace Wipro_ListCollection_Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Teacher> lstTeachers = new List<Teacher>();

            Teacher objTeacher1 = new Teacher()
            {
                TeacherId = 101, 
                TeacherName = "Rahul", 
                TeacherQualification = "Phd in Physics", 
                TeacherEmail = "rahul987@gmail.com", 
                TeacherPhone = "+91-7865439648"
            };
            Teacher objTeacher2 = new Teacher()
            {
                TeacherId = 102,
                TeacherName = "Somnath",
                TeacherQualification = "Phd in Mathematics",
                TeacherEmail = "somnath876@gmail.com",
                TeacherPhone = "+91-7867435964"
            };
            Teacher objTeacher3 = new Teacher()
            {
                TeacherId = 103,
                TeacherName = "Bege",
                TeacherQualification = "Phd in Chemistry",
                TeacherEmail = "bege709@gmail.com",
                TeacherPhone = "+91-9865439648"
            };

            lstTeachers.Add(objTeacher1);
            lstTeachers.Add (objTeacher2);
            lstTeachers.Add(objTeacher3);

            List<Student> lstStudents = new List<Student>();

            Student objStudent1 = new Student()
            {
                StudentId = 1,
                StudentName = "Subham",
                StudentAddress = "India",
                StudentEmail = "sc021@gmail.com",
                StudentPhone = "+91-7384741470"
            };
            objStudent1.lstTeacher = lstTeachers;

            Student objStudent2 = new Student()
            {
                StudentId = 2,
                StudentName = "Rounak",
                StudentAddress = "USA",
                StudentEmail = "rounak219@gmail.com",
                StudentPhone = "+1-9876741470"
            };
            objStudent2.lstTeacher = lstTeachers;

            Student objStudent3 = new Student()
            {
                StudentId = 3,
                StudentName = "Suru",
                StudentAddress = "India",
                StudentEmail = "suru021@gmail.com",
                StudentPhone = "+91-9084741470"
            };
            objStudent3.lstTeacher = lstTeachers;

            lstStudents.Add(objStudent1);
            lstStudents.Add(objStudent2);
            lstStudents.Add(objStudent3);

            Console.WriteLine("===================================STUDENT DETAILS===================================");
            Console.WriteLine();

            foreach (var student in lstStudents)
            {
                Console.WriteLine($"=====================Student {student.StudentName} Details=====================");
                Console.WriteLine($"Student ID: {student.StudentId}   |   Student Name: {student.StudentName}   |   " +
                                  $"Student Address: {student.StudentAddress}   |   Student Email: {student.StudentEmail}   |   " +
                                  $"Student Phone: {student.StudentPhone}");

                Console.WriteLine("=====================Assigned Teachers=====================");
                foreach (var teacher in student.lstTeacher)
                {
                    Console.WriteLine($"Teacher ID: {teacher.TeacherId}   |  Teacher Name: {teacher.TeacherName}   |   " +
                                      $"Teacher Qualification: {teacher.TeacherQualification}   |   Teacher Email: {teacher.TeacherEmail}  |   " +
                                      $"Teacher Phone: {teacher.TeacherPhone}");
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
