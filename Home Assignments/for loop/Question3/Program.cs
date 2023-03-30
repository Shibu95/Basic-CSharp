using System;
namespace Question3
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Test Data : ");
            int number = int.Parse(Console.ReadLine());

            System.Console.Write("The first {0} natural number is:",number);

            int sum = 0;

            for(int i=1;i<=number;i++)
            {
                System.Console.Write(i+" ");
                sum=sum+i;
            }
            System.Console.WriteLine();
            System.Console.WriteLine("The sum of Natural number upto {0} terms : {1}",number,sum);
        }
    }
}