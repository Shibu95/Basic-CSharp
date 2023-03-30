using System;
namespace Question9
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            int number1=number+4-1;
            

            for(int i=1;i<=number;i++)
            {
                for(int j=number1;j>=1;j--)
                {
                    System.Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    System.Console.Write(i);
                }
                System.Console.WriteLine();
                number1--;
            
            }
        }
    }
}