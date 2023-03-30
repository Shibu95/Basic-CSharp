using System;
namespace Question5
{
    class Program 
    {
        public static void Main(string[] args)
        {
            DateTime toDay = DateTime.Now;

            System.Console.WriteLine("Future year : {0} is later than {1}",toDay,toDay.AddYears(-1));
            System.Console.WriteLine("Previous year : {0} is earlier than {1}",toDay,toDay.AddYears(1));

        }
    }
}