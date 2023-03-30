using System;
namespace Question10
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the string");
            string input = Console.ReadLine();

            string input1="";
            char[] array = input.ToCharArray();
            
            for(int i=input.Length-1;i>=0;i--)
            {
                input1=input1+array[i];
            }
            System.Console.WriteLine("The result is :"+input1.ToUpper());
        }
    }
}