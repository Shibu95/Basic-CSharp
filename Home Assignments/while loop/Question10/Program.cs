using System;
namespace Question10
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Count");
            int count =int.Parse(Console.ReadLine());

            int i=1;
            int sum=0;

            System.Console.Write("Number - ");

            while(i<=count)
            {
                System.Console.Write(i+" ");
                sum+=(i*i);
                i++;
            }
            System.Console.WriteLine();
            System.Console.WriteLine(sum);
        }
    }
}