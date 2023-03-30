using System;
namespace Question3
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            
            int i=1;

            
            while(i<=number)
            {
                if(i%5==0)
                {
                    System.Console.WriteLine(i+" ");
                }
                 i++;
            }
           
        }
    }
}