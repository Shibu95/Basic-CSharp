using System;
namespace Question4
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number1");
            int number1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter number2");
            int number2=int.Parse(Console.ReadLine());

            swapping(number1,number2);


        }

        static void swapping(int number1,int number2)
        {
            number1=number1+number2;
            number2=number1-number2;
            number1=number1-number2;

            System.Console.WriteLine("Swapping numbers are : {0} & {1}",number1,number2);
        }
    }
}