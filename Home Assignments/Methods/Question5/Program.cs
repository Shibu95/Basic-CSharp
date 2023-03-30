using System;
namespace Question5
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            int count=0;

            IsPrime(number,count);


        }

        static void IsPrime(int number,int count)
        {
            count=0;
            for(int i=1;i<=number;i++)
            {
                if(number%i==0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                System.Console.WriteLine("It is a prime number");
            }
            else
            {
                System.Console.WriteLine("It is a not prime");
            }
            
        }
    }
}