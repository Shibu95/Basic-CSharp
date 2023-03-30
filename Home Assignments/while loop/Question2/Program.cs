using System;
namespace Question2
{
    class Program 
    {
        public static void Main(string[] args)
        {
            string opinion;
            while(true)
            {
            System.Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            
            System.Console.WriteLine("Welcome "+name);

            System.Console.WriteLine("Do you want to continue");
            opinion =Console.ReadLine().ToUpper();

            if(opinion=="YES")
            {
                continue;
            }
            else
            {
                break;
            }
            }
            
            
        }
    }
}