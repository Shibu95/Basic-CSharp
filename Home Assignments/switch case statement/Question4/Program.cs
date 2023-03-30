using System;
namespace Question4
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the first integer");
            int number1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the second integer");
            int number2=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your choice : 1-addition, 2-substraction, 3-Multiplication, 4-Divison, 5-Exit");
            int number3=int.Parse(Console.ReadLine());

            int result;

            switch(number3)
            {
                case 1:
                {
                    result=number1+number2;
                    System.Console.WriteLine("The result is "+result);
                    break;
                }
                case 2:
                {
                    result=number1-number2;
                    System.Console.WriteLine("The result is "+result);
                    break;
                }
                case 3:
                {
                    result=number1*number2;
                    System.Console.WriteLine("The result is "+result);
                    break;
                }
                case 4:
                {
                    result=number1/number2;
                    System.Console.WriteLine("The result is "+result);
                    break;
                }
                
            }
        }
    }
}