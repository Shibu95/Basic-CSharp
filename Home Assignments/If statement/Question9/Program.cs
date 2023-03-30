using System;
namespace Question9
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input the 1st number");
            int number1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Input the 2nd number");
            int number2=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Input the 3rd number");
            int number3=int.Parse(Console.ReadLine());

            if(number1>number2)
            {
                if(number1>number3)
                {
                    System.Console.WriteLine("The 1st number is the greatest among three");
                }
                else
                {
                    System.Console.WriteLine("The 3rd number is the greatest among three");
                }
            }
            else if(number2>number3)
            {
                System.Console.WriteLine("The 2nd number is the greatest among three");
            }

        }
    }
}