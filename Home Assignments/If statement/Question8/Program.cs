using System;
namespace Question8
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            if(number>=0)
            {
                System.Console.WriteLine("{0} is a positive number",number);
            }
            else
            {
                System.Console.WriteLine("{0} is a negative number",number);
            }
        }
    }
}