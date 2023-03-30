using System;
namespace Question5
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a Number");
            int number = int.Parse(Console.ReadLine());

            int modulus ;
            int reverse=0;

           while(number>0)
            {
                modulus=number%10;
                reverse=(reverse*10)+modulus;
                number=number/10;
            }
            System.Console.WriteLine("Reverse number is : "+reverse);
        }
    }
}