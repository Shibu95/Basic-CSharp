using System;
namespace Question6
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the string");
            string input = Console.ReadLine().ToUpper();
            
            char[] input1 = input.ToCharArray();
            int vowels =0;
            int consonants =0;

            for(int i=0;i<input1.Length;i++)
            {
                if(input1[i]=='A' || input1[i]=='E' || input1[i]=='I' || input1[i]=='O' || input1[i]=='U' )
                {
                    vowels++;
                }
                else if(input[i]>='A' && input[i]<='Z')
                {
                    consonants++;
                }
            }

            System.Console.WriteLine("The total number of vowels in the string is : "+vowels);
            System.Console.WriteLine("The total number of consonants in the string is : "+consonants);
        }
    }
}