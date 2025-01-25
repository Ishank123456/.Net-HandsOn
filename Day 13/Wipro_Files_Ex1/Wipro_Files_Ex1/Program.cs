using System;
using System.IO;

namespace Wipro_Files_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathName = @"C:\Users\hp\myFile.txt";

            //Creating a File
            /*FileStream fs = File.Create(pathName);

            if(File.Exists(pathName))
            {
                Console.WriteLine("File is Created");
            }
            else
            {
                Console.WriteLine("File is not Created");
            }*/

            //Opening a File
            //FileStream fs1 = File.Open(pathName, FileMode.Open);

            //Reading a File
            string readTxt = File.ReadAllText(pathName);
            Console.WriteLine(readTxt);

            Console.ReadLine();
        }
    }
}
