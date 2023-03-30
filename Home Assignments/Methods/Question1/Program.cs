using System;
namespace Question1
{
    class Progran 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number");
            int number1=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter a another number");
            int number2=int.Parse(Console.ReadLine());

            int number3= Addition(number1,number2);
            System.Console.WriteLine("The sum of the 2 numbers : "+number3);
            
            
            
        }

        static int Addition(int number1,int number2)
        {
            return number1+number2;
        }
    }
}