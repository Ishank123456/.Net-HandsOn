using System;

namespace Wipro_SwitchCase_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Enter the Alphabet");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch))
            {
                case 'a':
                    Console.WriteLine($"{ch} is a Vowel");
                    break;
                case 'e':
                    Console.WriteLine($"{ch} is a Vowel");
                    break;
                case 'i':
                    Console.WriteLine($"{ch} is a Vowel");
                    break;
                case 'o':
                    Console.WriteLine($"{ch} is a Vowel");
                    break;
                case 'u':
                    Console.WriteLine($"{ch} is a Vowel");
                    break;
                default:
                    Console.WriteLine($"{ch} is not a Vowel");
                    break;
            }
            Console.ReadLine();
            goto start;
        }
    }
}
