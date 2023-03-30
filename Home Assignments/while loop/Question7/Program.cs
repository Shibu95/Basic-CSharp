using System;
namespace Question7
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int i=1;
            string even = "";
            string odd ="";
            string prime ="";

            while(i<=100)
            {
                if(i%2==0)
                {
                    even=even+i+" ";
                }
                else if(i%2==1)
                {
                   odd=odd+i+" ";
                }
                i++;
            }
            int j=2;
            while(j<100)
            {
                int k=j/2;
                int l=0;
                for(int m=2;m<k;m++)
                {
                    if(j%k==0)
                    {
                        l=1;
                        break;
                    }

                }
                if(l==0)
                {
                    prime=prime+j+" ";
                }
                j++;
            }
            System.Console.WriteLine(even);
            System.Console.WriteLine(odd);
            System.Console.WriteLine(prime);
           
        }
    }
}