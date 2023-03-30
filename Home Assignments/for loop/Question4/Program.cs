using System;
namespace Question4
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input the numbers");
            int[] array = new int[10];


            for(int i=0;i<array.Length;i++)
            {
                System.Console.Write("Number {0} : ",i);
                array[i]=int.Parse(Console.ReadLine());  
            }
            float sum =0;

            for(int i=0;i<array.Length;i++)
            {
                sum=sum+array[i];
            }
            float average = sum/10;
            System.Console.WriteLine("The sum of 10 number is : "+sum);
            System.Console.WriteLine("The average is : "+average);
        }
    }
}