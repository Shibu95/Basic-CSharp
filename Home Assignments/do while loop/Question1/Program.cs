using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string choice;
            int number;
            do
            {
                System.Console.WriteLine("Input Number");
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 1)
                {
                    System.Console.WriteLine("Given number is an odd number");
                }
                else
                {
                    System.Console.WriteLine("Given number is an even number");
                }

                System.Console.WriteLine("Input choice");
                choice = Console.ReadLine().ToUpper();

            }
            while (choice == "YES");
            {
                number++;
            }
        }
    }
}