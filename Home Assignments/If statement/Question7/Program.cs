using System;
namespace Question7
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a year -yyyy");
            int year = int.Parse(Console.ReadLine());

            if(year%4==0)
            {
                System.Console.WriteLine("{0} is a leap year",year );
            }
        }
    }
}