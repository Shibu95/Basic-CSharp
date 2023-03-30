using System;
namespace Question2
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter the count : ");
            int count=int.Parse(Console.ReadLine());

            int[] array=new int[count];
            int i=0;
            int sum=0;

            do
            {
                System.Console.WriteLine("Enter the {0} number: ",i);
                array[i]=int.Parse(Console.ReadLine());
                i++;
            }while(i<count);
            for(i=0;i<array.Length;i++)
            {
                if(array[i]>0)
                {
                    sum+=array[i];
                }
            }
            System.Console.Write("The sum is : "+sum);
            
        }
    }
}