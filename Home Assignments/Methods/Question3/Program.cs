using System;
namespace Question3
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int sum=0;
            int[] elements = {5,7,3,2,9};

            addition(sum,elements);
           

        }
        static void addition(int sum,int[] elements)
        {
            sum=0;
            for(int i=0;i<elements.Length;i++)
            {
                sum=sum+elements[i];
            }
            System.Console.WriteLine(sum);
            
        }
    }
}