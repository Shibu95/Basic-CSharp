using System;
namespace Question3
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int[] array = new int[3];
            int sum=0;

            System.Console.WriteLine("Input 3 elements in the array :");
            for(int i=0;i<array.Length;i++)
            {
                System.Console.Write("element-{0}:",i);
                array[i] = int.Parse(Console.ReadLine());
            }

            foreach(int array1 in array )
            {
                sum = sum+array1;
            }
            System.Console.WriteLine("Sum of all elements stored in the array is : "+sum);

        }
    }
}