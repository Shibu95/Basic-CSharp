using System;
namespace Question3
{
    class Program 
    {
        public static void Main(string[] args)
        {
            char choice;
            char input;
            do
            {
                System.Console.WriteLine("What is the command keyword to exit a loop in C#?");
                System.Console.WriteLine("a.int \n b.continue \n c.break \n d.exit");
                choice=char.Parse(Console.ReadLine().ToLower());
                if(choice=='c')
                {
                    System.Console.WriteLine("Correct");
                    break;
                }
                else
                {
                    System.Console.WriteLine("Incorrect!");
                }
                System.Console.WriteLine("Try Again? press y to continue");
                input=char.Parse(Console.ReadLine().ToLower());
            }
            while(input=='y');
          
        }
    }
}