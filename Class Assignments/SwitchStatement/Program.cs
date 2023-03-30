
using System;
namespace SwitchStatement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input1");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input2");
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Operation +, -, *, /, %");
            char operation = char.Parse (Console.ReadLine());

            switch(operation)
            {
                case'+':
                {
                    Console.WriteLine(input1 += input2);
                    break;
                }
                case'-':
                {
                    Console.WriteLine(input1 -= input2);
                    break;
                }
                case'*':
                {
                    Console.WriteLine(input1 *= input2);
                    break;
                }
                case'/' :
                {
                    Console.WriteLine(input1/=input2);
                    break;
                }
                case'%' :
                {
                    Console.WriteLine(input1%input2);
                    break;
                }
                default:
                {
                    Console.WriteLine("Operation is Invalid");
                    break;
                }
            }
        }
    }
}