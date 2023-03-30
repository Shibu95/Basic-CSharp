using System;
namespace Question5
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input the 1st string");
            string input=Console.ReadLine();
            
            System.Console.WriteLine("Input the 2nd string");
            string input1=Console.ReadLine();
            
            if(input.Equals(input1))
            {
                System.Console.WriteLine("The length of both string is equal and also both strings are equal");
            }
        }
    }
}