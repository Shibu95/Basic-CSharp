using System;
namespace DoWhile
{
    class Program
    {
        public static void Main(string[] args)
        {
            string option;
            do
            {
            System.Console.WriteLine("number");
            int number=int.Parse(Console.ReadLine());

            if(number%2==0)
            {
                System.Console.WriteLine("Given number is even");
            }
            else
            {
                System.Console.WriteLine("Given number is odd");
            }
            
                System.Console.WriteLine("Repeat the process with other number");
                option=Console.ReadLine().ToUpper();
            }

            while(option=="NO" && option=="YES");
            {
                    System.Console.WriteLine("Provide input");
                    option=Console.ReadLine().ToUpper();

                    if(option=="YES") 
                    {
                        System.Console.WriteLine("Enter input");
                    } 
            }
              
                
                
            }

            

    }
}
