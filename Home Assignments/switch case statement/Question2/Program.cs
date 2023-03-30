using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input");
            int input = int.Parse(Console.ReadLine());

            switch(input%2) 
            {
                case 0:
                {
                    System.Console.WriteLine("{0} is an even", input);
                    break;
                }
                case 1:
                {
                    System.Console.WriteLine("{0} is an odd", input );
                    break;
                }
            }
        }
    }
}