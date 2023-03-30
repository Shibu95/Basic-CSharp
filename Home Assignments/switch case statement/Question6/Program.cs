using System;
namespace Question6
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number1");
            int number1 =int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the number2");
            int number2=int.Parse(Console.ReadLine());

            switch(number1>number2)
            {
                case false:
                {
                    System.Console.WriteLine(number2);
                    break;
                }
                case true:
                {
                    System.Console.WriteLine(number1);
                    break;
                }
            }
            
        }
    }
}