using System;
namespace Question10
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter the Date1 : ");
            DateTime date1=DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy",null);

            System.Console.Write("Enter the Date2 : ");
            DateTime date2=DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy",null);

            TimeSpan days=date2-date1;

            System.Console.WriteLine("The difference in the dates is {0} days",days.Days);
        }
    }
}