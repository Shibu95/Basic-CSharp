using System;
namespace Question6
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Input the size of Array : ");
            int sizeOfArray = int.Parse(Console.ReadLine());

            int[] array = new int[sizeOfArray];

            for(int i=0;i<array.Length;i++)
            {
                System.Console.Write("element-{0} :  ",i);
                array[i]=int.Parse(Console.ReadLine());  
            }
            Array.Sort(array);
            foreach(int array1 in array)
            {
            System.Console.WriteLine(array1);
            }
        }
    }
}