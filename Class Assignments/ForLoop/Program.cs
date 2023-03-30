using System;
namespace ForLoop
{
    class Program
    {
        public static void Main(string[] args)
        {
            for(int i=0;i<=25;i++)
            {
                int evenNumber= i%2;
                if(evenNumber==0)
                {
                    Console.WriteLine("EvenNumbers : "+i);
                }
                
            }

            Console.WriteLine("Initial Value");
            int value1=int.Parse(Console.ReadLine());

            Console.WriteLine("Final Value");
            int value2=int.Parse(Console.ReadLine());

            int sum =0;

            for(int i=value1;i<=value2;i++)
            {
             sum = sum+(i*i);
            }
             Console.WriteLine("Sum of square: "+sum);
        }
    }
}