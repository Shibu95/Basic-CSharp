using System.Runtime.ConstrainedExecution;
using System;
namespace Question5
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a letter");
            string letter = Console.ReadLine().ToUpper();

            switch(letter)
            {
                case "A":
                case "E":
                case "I":
                case "O":
                case "U":
                {
                    System.Console.WriteLine("It is a vowel");
                    break;
                }
                default:
                {
                    System.Console.WriteLine("not a vowel");
                    break;
                }
            }
            
        }
    }
}