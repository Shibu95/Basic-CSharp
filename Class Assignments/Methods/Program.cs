using System;
namespace MethodsAssignment
{
    class Program 
    {
        public static void Main(string[] args)
        {
            string opinion1;
            do
            {
            System.Console.WriteLine("Enter number1");
            int number1=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter number2");
            int number2=int.Parse(Console.ReadLine());

            
            
            System.Console.WriteLine("Opinion - 1, 2, 3, 4");
            int opinion=int.Parse(Console.ReadLine());
            
            int answer = 0;
            switch(opinion)
            {
                case 1:
                {
                    answer = Addition( number1,number2 );
                    System.Console.WriteLine(answer);
                    break;
                }
                case 2:
                {
                    answer= Subtraction(number1,number2);
                    System.Console.WriteLine(answer);
                    break;
                }
                case 3:
                {
                    answer= Multiplication(number1,number2);
                    System.Console.WriteLine(answer);
                    break;
                }
                case 4:
                {
                    answer=division(number1,number2);
                    System.Console.WriteLine(answer);
                    break;
                }
                
            }

            System.Console.WriteLine("Do you want to continue : yes no");
            opinion1 = Console.ReadLine().ToUpper();

            }
            while(opinion1=="YES");
            



        }    
            
            static int Addition(int number1,int number2)
            {
                return number1+number2; 
            }
            static int Subtraction(int number1,int number2)
            {
                return number1-number2;
            }
            static int Multiplication(int number1, int number2)
            {
                return number1*number2;
            }
            static int division(int number1, int number2)
            {
                return number1/number2;
            }

        
    }
}