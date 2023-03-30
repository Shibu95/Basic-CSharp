using System;
namespace Question9
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter the string1 : ");
            string input1=Console.ReadLine();
            
            System.Console.Write("Enter the string2 : ");
            string input2=Console.ReadLine();
            

            string result ="";
            int x=0;
            int index=1;

            x=string.CompareOrdinal(input1,index,input2,index,1);
            if(x<0)
            {
                result="less than";
            }
            else if(x>0)
            {
                result="greater than";
            }
            System.Console.WriteLine("string {0} is {1} string {2}",input1,result,input2);
        }
    }
}