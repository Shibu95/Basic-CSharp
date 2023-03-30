using System;
namespace Question1
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10];

            for(int i=0;i<array.Length;i++)
            {
                System.Console.Write("element - {0} ",i);
                array[i]=int.Parse(Console.ReadLine());
            }

            System.Console.Write("Elements in array are : ");

            foreach(int array1 in array)
            {
                System.Console.Write(array1+" ");
            }



        }
    }
}