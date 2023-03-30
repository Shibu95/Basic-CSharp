using System;
namespace Question8
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the date - dd/MM/yyyy");
            DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

           //DayOfWeek day = date.DayOfWeek;

            System.Console.WriteLine(date.ToLongDateString());
        }
    }
}