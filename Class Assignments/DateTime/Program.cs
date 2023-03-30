using System;
namespace DateTimeAssignment
{
    class Program 
    {
        public static void Main(string[] args)
        {  
           DateTime data = new DateTime(2021, 8, 10, 10, 40, 32);

            System.Console.WriteLine(data.Date);
            System.Console.WriteLine(data.Year);
            System.Console.WriteLine(data.Month);
            System.Console.WriteLine(data.Day);
            System.Console.WriteLine(data.Hour);
            System.Console.WriteLine(data.Minute);
            System.Console.WriteLine(data.Second);

            string data1 = data.ToString();
            System.Console.WriteLine(data1);

            string[] data2 = data1.Split('/',' ',':');

            for(int i=data2.Length-1;i>=0;i--)
            
            System.Console.WriteLine(data2[i]);

            System.Console.WriteLine("object in string format");
            DateTime data3= DateTime.ParseExact(Console.ReadLine(),"yyyy:MM:dd hh:mm:ss tt", null);

            System.Console.WriteLine("year = "+ data3.Year);
            System.Console.WriteLine("month = "+ data3.Month);
            System.Console.WriteLine("day = "+data3.Day);
            
            
            
   
        }
    }
}