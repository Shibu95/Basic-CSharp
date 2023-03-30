using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            int[] array = new int[number];

            int i=0;

            while(i<array.Length)
            {
                System.Console.WriteLine();
                array[i]=int.Parse(Console.ReadLine());

                i++;
            }
            int sum=0;
            for( i=0;i<array.Length;i++)
            {
                sum+=array[i];
            }
            System.Console.WriteLine(sum);
            
        }
    }
}