using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace Question2
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Input the String : ");
            string input = Console.ReadLine();

            System.Console.WriteLine("The length of the string is : "+input.Length);
            
        }
    }
}