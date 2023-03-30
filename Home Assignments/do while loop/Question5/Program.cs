using System;
namespace Question5
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());

            int i=1;
            do
            {
                System.Console.WriteLine("{0}*{1}={2}",number,i,number*i);
                i++;
            }
            while(i<=10);
        }
    }
}