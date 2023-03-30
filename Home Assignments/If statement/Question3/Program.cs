using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the finish time1 in seconds");
        int time1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the finish time2 in seconds");
        int time2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the finish time3 in seconds");
        int time3=int.Parse(Console.ReadLine());

        int seconds=time1+time2+time3;
        int minutes=0;

        if(seconds>59)
        {
            seconds=seconds-60;
            minutes=minutes+1;
        }
        if(seconds>59)
        {
            seconds=seconds-60;
            minutes++;
        }
        if(seconds<10)
        {
            System.Console.WriteLine("Time: {0}:0{1}",minutes,seconds);
        }
        else
        {
            System.Console.WriteLine("Time: {0}:{1}",minutes,seconds);
        }
    }
}