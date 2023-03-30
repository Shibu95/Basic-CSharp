using System;
namespace Question3
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Input the String : ");
            string input= Console.ReadLine();
            
            char[] input1=input.ToCharArray();

            foreach(char i in input1)
            {
                System.Console.Write(i+" ");
            }
        }
    }
}