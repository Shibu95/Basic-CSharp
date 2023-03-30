using System;
namespace Question4
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a date in this format dd-MM-yyyy");
            DateTime inputDate=DateTime.ParseExact(Console.ReadLine(),"dd-MM-yyyy",null);

            System.Console.WriteLine("past 15th year "+inputDate.AddYears(-15));
            System.Console.WriteLine("future 15th year "+inputDate.AddYears(15));
            
        }
    }
}