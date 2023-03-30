using System;
namespace Program
{
    class Assignment1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            string name= Console.ReadLine();

            Console.WriteLine("Enter Age");
            int age= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter mark of Subject1");
            int mark1= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter mark of Subject2");
            int mark2= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter mark of Subject3");
            int mark3= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter grade");
            string grade=Console.ReadLine();

            Console.WriteLine("Enter mobile no");
            long number=long.Parse(Console.ReadLine());

            Console.WriteLine("Enter mail ID");
            string mailId=Console.ReadLine();

            int total= mark1+mark2+mark3;
            double average= (double)total/3;

            Console.WriteLine("Trainee Details are:");
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Mobile: "+number);
            Console.WriteLine("Mark1: "+mark1);
            Console.WriteLine("Mark2: "+mark2);
            Console.WriteLine("Mark3: "+mark3);
            Console.WriteLine("Total: "+total);
            Console.WriteLine("Average: "+average);
            Console.WriteLine("Grade: "+grade);
            Console.WriteLine("Mail Id: "+mailId);




        }
    }
}