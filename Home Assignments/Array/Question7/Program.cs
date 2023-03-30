using System;
namespace Question7
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int[,] matrix = new int[3,3];
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    System.Console.WriteLine("Enter the numbers");
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    System.Console.Write(matrix[i,j]+" ");
                }
                System.Console.WriteLine();
            }
        }
    }
}