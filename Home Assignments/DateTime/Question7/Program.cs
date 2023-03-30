using System;
namespace Question7
{
    class Program 
    {
        public static void Main(string[] args)
        {

            System.Console.Write("Enter the month - MM : ");
            int month = int.Parse(Console.ReadLine());
            System.Console.Write("Enter the year -yyyy : ");
            int year = int.Parse(Console.ReadLine());


            int days = DateTime.DaysInMonth(year,month);
            System.Console.WriteLine(days);

        }
    }
}