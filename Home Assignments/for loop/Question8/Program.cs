using System;
namespace Question8
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            int number2 = number-1;
            int length=1;
            for(int i=1;i<=number;i++)
            {
                for(int j=1;j<=number2;j++)
                {
                    System.Console.Write(" ");
                }
                for(int k=1;k<=length;k++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
                number2--;
                length+=2;
            }
        }
    }
}