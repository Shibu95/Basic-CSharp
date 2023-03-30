using System;
namespace Question8
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the limit");
            int number = int.Parse(Console.ReadLine());

            
            int start=1;
            int value1=0;
            int value2=1;
            int value3;

            while(start<=number)
            {
                
                System.Console.Write(value1+" ");
                value3=value1+value2;
                value1=value2;
                value2=value3;

                start++;

            }
            System.Console.ReadLine();
        }
        
        
    }
}