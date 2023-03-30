using System;
namespace Question7
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Input 1 : ");
            int number1=int.Parse(Console.ReadLine());

            System.Console.Write("Input 2 : ");
            int number2=int.Parse(Console.ReadLine());

            int number3= addition(number1,number2);
            System.Console.WriteLine("Addition : "+number3);
            int number4= substraction(number1,number2);
            System.Console.WriteLine("Substraction : "+number4);
            int number5= multiplication(number1,number2);
            System.Console.WriteLine("Multiplication : "+number5);
            int number6= division(number1,number2);
            System.Console.WriteLine("Division : "+number6);
            
            
            
        }

        static int addition(int number1,int number2)
        {
            return number1+number2;
        }
        static int substraction(int number1,int number2)
        {
            return number1-number2;
        }
        static int multiplication(int number1,int number2)
        {
            return number1*number2;
        }
        static int division(int number1,int number2)
        {
            return number1/number2;
        }
        
    }
}