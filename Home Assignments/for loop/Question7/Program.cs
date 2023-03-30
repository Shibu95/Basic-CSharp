using System;
namespace Question7
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Input the number of terms : ");
            int number = int.Parse(Console.ReadLine());
            int sum =0;
            int output =1;

            for(int i=1;i<=number;i++)
            {
                System.Console.Write("{0} + ",output);
                sum +=output;
                output = (output*10)+1;
            }
            System.Console.WriteLine();
            System.Console.WriteLine("The sum is : "+sum);
            
        }
    }
}