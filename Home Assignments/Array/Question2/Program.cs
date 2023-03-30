using System;
namespace Question2
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int[] array=new int[3]{2,5,7};

            System.Console.Write("The values store into the array are : ");
            foreach(int array1 in array)
            {
                System.Console.Write(array1+" ");
            }
            System.Console.WriteLine();
            System.Console.Write("The values store into the array in reverse are : ");

            Array.Reverse(array);
            foreach(int array2 in array)
            {
                System.Console.Write(array2+" ");
            }
        }
    }
}