using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input");
            int input = int.Parse(Console.ReadLine());

            if(input==0)
            {
              System.Console.WriteLine("Zero");
            }
            else if(input==1)
            {
              System.Console.WriteLine("One");  
            }
            else if(input==2)
            {
              System.Console.WriteLine("Two");  
            }
            else if(input==3)
            {
               System.Console.WriteLine("Three"); 
            }
            else if(input==4)
            {
               System.Console.WriteLine("Four"); 
            }
            else if(input==5)
            {
               System.Console.WriteLine("Five"); 
            }
            else if(input==6)
            {
               System.Console.WriteLine("Six"); 
            }
            else if(input==7)
            {
               System.Console.WriteLine("Seven"); 
            }
            else if(input==8)
            {
               System.Console.WriteLine("Eight");
            }
            else if(input==9)
            {
               System.Console.WriteLine("Nine"); 
            }
            else if(input>9)
            {
                System.Console.WriteLine("Number to big");
            }
        }
    }
}