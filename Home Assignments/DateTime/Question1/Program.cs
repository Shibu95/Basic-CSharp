using System;
namespace Question1
{
    class Program 
    {
        public static void Main(string[] args)
        {
            DateTime toDay = DateTime.Now;

            System.Console.WriteLine("year = "+toDay.Year);
            System.Console.WriteLine("month = "+toDay.Month);
            System.Console.WriteLine("day = "+toDay.Day);
            System.Console.WriteLine("hour = "+toDay.Hour);
            System.Console.WriteLine("minute = "+toDay.Minute);
            System.Console.WriteLine("second = "+toDay.Second);
            System.Console.WriteLine("millisecond = "+toDay.Millisecond);
        }
    }
}