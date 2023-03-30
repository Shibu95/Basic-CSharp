using System;
namespace Question8;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number");
        int number=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the index");
        int index=int.Parse(Console.ReadLine());

        FindnthDigit(number,index);
    }

    static void FindnthDigit(int number,int index)
    {
        int number1=0;
        int result=0;

        while(number1<index)
        {
            result=number%10;
            number=number/10;
            number1++;
        }
            System.Console.WriteLine(result);
    }
}