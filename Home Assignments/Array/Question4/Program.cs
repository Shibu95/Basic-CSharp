using System;
namespace Question4
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int[] array = new int[3];

            System.Console.WriteLine("Input 3 elements in Array :");

            for(int i=0;i<array.Length;i++)
            {
                System.Console.Write("element-{0}",i+" ");
                array[i]=int.Parse(Console.ReadLine());
            }

            int maximumValue=array[0];
            int minimumValue=array[0];
            for(int i=0;i<array.Length;i++)
            {
                if(array[i]>maximumValue)
                {
                    maximumValue=array[i];
                }
                if(array[i]<minimumValue)
                {
                    minimumValue=array[i];
                }
            }
            System.Console.WriteLine("Maximum element is : "+maximumValue);
            System.Console.WriteLine("Minimum element is : "+minimumValue);
        }
    }
}