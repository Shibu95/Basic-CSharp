using System;
namespace Question8
{
    class program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a month");
            string month = Console.ReadLine().ToUpper();

            switch(month)
            {
                case "DECEMBER":
                {
                    System.Console.WriteLine("Winter");
                    break;
                } 
                case "JANUARY":
                {
                    System.Console.WriteLine("Winter");
                    break;
                } 
                case "FEBRUARY":
                {
                    System.Console.WriteLine("Winter");
                    break;
                } 
                case "MARCH":
                {
                    System.Console.WriteLine("Spring");
                    break;
                }
                case "APRIL":
                {
                    System.Console.WriteLine("Spring");
                    break;
                }
                case "MAY":
                {
                    System.Console.WriteLine("Spring");
                    break;
                }
                case "JUNE":
                {
                    System.Console.WriteLine("Summer");
                    break;
                }
                case "JULY":
                {
                    System.Console.WriteLine("Summer");
                    break;
                }
                case "AUGUST":
                {
                    System.Console.WriteLine("Summer");
                    break;
                }
                case "SEPTEMBER":
                {
                    System.Console.WriteLine("Rainfall");
                    break;
                }
                case "OCTOBER":
                {
                    System.Console.WriteLine("Rainfall");
                    break;
                }
                case "NOVEMBER":
                {
                    System.Console.WriteLine("Rainfall");
                    break;
                }
            }
            
        }
    }
}

