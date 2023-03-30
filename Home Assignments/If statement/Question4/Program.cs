using System;
namespace Question4
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input");
            float input = float.Parse(Console.ReadLine());

            if(input>0 && input<=10)
            {
                System.Console.WriteLine("Slow");
            }
            else if(input>10 && input<=50)
            {
                System.Console.WriteLine("Average");
            }
            else if(input>50 && input<=150)
            {
                System.Console.WriteLine("Fast");
            }
            else if(input>150 && input<=1000)
            {
                System.Console.WriteLine("ultra fast");
            }
            else if(input>1000)
            {
                System.Console.WriteLine("Extremely Fast");
            }
        }
    }
}