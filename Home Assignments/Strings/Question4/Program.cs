using System;
namespace Question4
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input the string");
            string input = Console.ReadLine();
            
            string[] input1=input.Split(" ");

            System.Console.WriteLine("The total number of words in the string is : "+input1.Length);
        }
    }
}