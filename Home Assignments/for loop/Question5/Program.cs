using System;
namespace Question5
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Input number of terms: ");
            int number = int.Parse(Console.ReadLine());

            int cube;
            for(int i=1;i<=number;i++)
            {
                cube=i*i*i;
                System.Console.WriteLine("Number is : {0} and cube of the {0} is : {1}",i,cube);
            }
            
        }
    }
}