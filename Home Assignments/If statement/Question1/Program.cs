using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input");
            double input = double.Parse(Console.ReadLine());

            if(input >= 5.5)
            {
                System.Console.WriteLine("Excellent");
            }
            else
            {
                System.Console.WriteLine("Not Excellent");
            }
            
        }
    }
}