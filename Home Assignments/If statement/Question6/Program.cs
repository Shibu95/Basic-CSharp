using System;
namespace Question6
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Temperature in centigrade");
            float temperature=float.Parse(Console.ReadLine());

            if(temperature<0)
            {
                System.Console.WriteLine("Freezing weather");
            }
            if(temperature>=0 && temperature<=10)
            {
                System.Console.WriteLine("Very cold weather");
            }
            if(temperature>10 && temperature<=20)
            {
                System.Console.WriteLine("Cold weather");
            }
            if(temperature>20 && temperature<=30)
            {
                System.Console.WriteLine("Normal in temp");
            }
            if(temperature>30 && temperature<40)
            {
                System.Console.WriteLine("Its Hot");
            }
            if(temperature>=40)
            {
                System.Console.WriteLine("Its very hot");
            }
        }
    }
}