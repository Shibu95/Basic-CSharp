using System;
namespace Question6
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            int count=0;
            int sum=0;

            while(true)
            {
                if(number==count)
                {
                    break;
                }
                    System.Console.WriteLine("number {0} is : ",count+1);
                    int number1=int.Parse(Console.ReadLine());
                    sum+=number1;
                
                count++;
                
            }
            System.Console.WriteLine("Sum of given numbers is : "+sum);


        }
    }
}