using System;
namespace Question9
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the start year-yyyy");
            int year1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the end year-yyyy");
            int year2=int.Parse(Console.ReadLine());

           

            for(int i=year1;i<=year2;i++)
            {
                if(DateTime.IsLeapYear(i))
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}