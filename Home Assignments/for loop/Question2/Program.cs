using System;
namespace Question2
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int sum =0, i;
            System.Console.WriteLine("The first 10 natural number is : ");
            for ( i=1; i<=10; i++)
            {
                System.Console.WriteLine(i);

                sum = sum +i;
            }
               System.Console.WriteLine("The sum is : "+sum);
            
        }
    }
}