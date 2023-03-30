using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {

            System.Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int modulus;


            do
            {
                modulus = number % 10;
                sum = sum + modulus;
                number = number / 10;
            }

            while (number > 0);
            {
                number++;
            }

            System.Console.WriteLine(sum);



        }
    }
}