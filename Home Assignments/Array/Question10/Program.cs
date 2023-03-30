using System;
namespace Question10
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int[,] matrix=new int[2,2];

            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    System.Console.WriteLine("Enter the numbers");
                    matrix[i,j]=int.Parse(Console.ReadLine());
                }
            }
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    System.Console.Write(matrix[i,j]+" ");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("The transposed matrix is ");
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    System.Console.Write(matrix[j,i]+" ");
                }
                System.Console.WriteLine();
            }
        }
    }
}