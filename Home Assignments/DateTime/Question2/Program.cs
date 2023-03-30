using System;
namespace Question2
{
    class Program 
    {
        public static void Main(string[] args)
        {
            DateTime toDay = DateTime.Now;
            System.Console.WriteLine("Today = "+toDay);

            DateTime dayOfWeek = toDay.AddDays(40);
            System.Console.WriteLine(dayOfWeek.DayOfWeek);

            
        }
    }
}