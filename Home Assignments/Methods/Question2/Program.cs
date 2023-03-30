using System;
namespace Question2
{
    class Program 
    {
        public static void Main(string[] args)
        {
            
            System.Console.WriteLine("Please input a string");
            string input=Console.ReadLine();

            input2(input);
            
        }

        static void input2(string input)
        {
            string[] input2=input.Split(" ");
           
            System.Console.WriteLine(input2.Length-1);

        }
    }
}