using System;
namespace Question7
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input the original string :");
            string input1=Console.ReadLine();
            System.Console.WriteLine("Input the string to be searched for :");
            string input2=Console.ReadLine();
            System.Console.WriteLine("Input the string to be insert :");
            string input3=Console.ReadLine();

            int index=input1.IndexOf(input2);

            string result = input1.Insert(index,input3+" ");

            System.Console.WriteLine("The modified string is :"+result);
            
        }
    }
}