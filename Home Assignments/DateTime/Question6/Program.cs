using System;
namespace Question6
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Date - MM/dd/yyyy");
            DateTime date1 = DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy",null);

            DateTime date2 = DateTime.Now;

            int result = DateTime.Compare(date1,date2);


           if(result>0)
            {
                System.Console.WriteLine("{0} is in the future",date1.Date);
            }
            else
            {
                System.Console.WriteLine("{0} is in the past",date1.Date);
            }
        }
    }
}