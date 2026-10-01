using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a letter:");
            String letter = Console.ReadLine();
            String ans = " is a vowel";

            switch (letter)
            {
                case "a":
                    Console.WriteLine(letter + ans);
                break;
                case "e":
                    Console.WriteLine(letter + ans);
                    break;
                case "i":
                Console.WriteLine(letter + ans);
                    break;
                case "o":
                    Console.WriteLine(letter + ans);
                    break;
                case "u":
                Console.WriteLine(letter + ans);
                    break;
                default:
                    Console.WriteLine(letter + " is not a vowel");
                    break;
            }
        }
    }
}
