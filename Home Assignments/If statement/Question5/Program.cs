using System;
namespace Question5
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a age");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Gender - F/M");
            string gender =Console.ReadLine().ToUpper();

            if(age>=16 && gender=="M")
            {
                System.Console.WriteLine("Mr");
            }
            else if(age<16 && gender=="M")
            {
                System.Console.WriteLine("Master");
            }
            else if(age>=16 && gender=="F")
            {
                System.Console.WriteLine("Ms");
            }
            else if(age<16 && gender=="F")
            {
                System.Console.WriteLine("Miss");
            }
            
        }
    }
}