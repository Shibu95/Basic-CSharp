using System;
namespace Question9
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int[,] matrix1=new int[2,2];
            int[,] matrix2=new int[2,2];

            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    System.Console.WriteLine("Enter the numbers");
                    matrix1[i,j]=int.Parse(Console.ReadLine());
                }
            }
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    System.Console.Write(matrix1[i,j]+" ");
                }
                System.Console.WriteLine();
            }
            
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    System.Console.WriteLine("Enter the numbers");
                    matrix2[i,j]=int.Parse(Console.ReadLine());
                }
            }
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    System.Console.Write(matrix2[i,j]+" ");
                }
                System.Console.WriteLine();
            }

            int[,] matrix3=new int[2,2];
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    for(int k=0;k<2;k++)
                    {
                        matrix3[i,j]=matrix3[i,j]+matrix1[i,k]*matrix2[k,j];
                    }
                }
            }
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    System.Console.Write(matrix3[i,j]+" ");
                }
                System.Console.WriteLine();
            }
            

        }
    }
}