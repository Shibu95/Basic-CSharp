using System;
namespace Question6
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter mark1");
            int mark1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter mark2");
            int mark2=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter mark3");
            int mark3=int.Parse(Console.ReadLine());
            float percent=0;

            System.Console.WriteLine("Mark 1 : "+mark1);
            System.Console.WriteLine("Mark 2 : "+mark2);
            System.Console.WriteLine("Mark 3 : "+mark3);
            percentage(mark1,mark2,mark3,percent);

        }

        static void percentage(int mark1,int mark2, int mark3, float percent)
        {
            int sum = mark1+mark2+mark3;
            percent =sum/3;
            System.Console.WriteLine("Percentage : "+percent);
        }
    }
}