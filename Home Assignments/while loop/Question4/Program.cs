using System;
namespace Question4
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            int i=1;
            int sum =0;

            while(i<=number)
            {
                sum+=i;
                i++;
            }
            System.Console.WriteLine(sum);

        }
    }
}