using System;
namespace Question3
{
    class Program 
    {
        public static void Main(string[] args)
        {
            DateTime toDay = DateTime.Now;
            System.Console.WriteLine("Today "+toDay.DayOfWeek);

            DateTime result= toDay.AddDays(40);
            System.Console.WriteLine("40days from today "+result.DayOfWeek);
        }
    }
}