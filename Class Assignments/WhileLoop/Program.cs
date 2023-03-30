using System;
namespace WhileLoop
{
    class Program
    {
        public static void Main(string[] args)
        {
            int value =0;

            while(value<=25)
            {
                
                if(value%2==0)
                {
                    Console.WriteLine("Even number : "+value);
                }
                value=value+1;
            }
            //Exercise 2

            int result =0;
            while(true)
            {
                System.Console.WriteLine("Enter a no");
                string number=Console.ReadLine();
                
                bool valid= int.TryParse(number, out result);
                if(valid==true)
                {
                    System.Console.WriteLine(result);
                    break;
                }
                else
                {
                    System.Console.WriteLine("invalid");
                }
            }

            
        }
    }
}