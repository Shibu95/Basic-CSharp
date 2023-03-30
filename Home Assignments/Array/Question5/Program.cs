using System;
namespace Question5
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int[] array = new int[5];
            System.Console.WriteLine("Input 5 elements in the array :");
            for(int i=0;i<array.Length;i++)
            {
                System.Console.WriteLine("element-{0}:",i);
                array[i]=int.Parse(Console.ReadLine());
            }

            string oddArray = "";
            string evenArray = "";
            
           foreach(int array1 in array)
          
            {
                if(array1%2==1)
                {
                    oddArray=oddArray+array1+" ";
                
                }
                else
                {
                    evenArray=evenArray +array1+" ";
                
                }
            }
            System.Console.WriteLine("The even elements are : "+evenArray);
            
            System.Console.WriteLine("The Odd elements are : "+oddArray);
            


        }
    }
}