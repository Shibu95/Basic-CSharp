using System;
namespace Question10
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Input the number of terms : ");
            int number = int.Parse(Console.ReadLine());

            float harmonic;
            float sum=0;
            for(float i=1;i<=number;i++)
            {
                System.Console.Write("1/{0}+",i);

                harmonic=(1/i);
                sum=sum+harmonic;
               
            }
            System.Console.WriteLine();
            System.Console.WriteLine("sum of series upto {0} terms : {1}",number,sum);
        }
    }
}