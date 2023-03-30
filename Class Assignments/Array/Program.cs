using System;
namespace Array
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] names=new string[5];
            int count=0;
            names[0] = "Mani";
            names[1] = "Ganesh";
            names[2] = "Rama";
            names[3] = "Krishna";
            names[4] = "Perumal";

            for( int i=0; i<=names.Length-1;i++)
            {
            System.Console.WriteLine("All names : "+names[i]);
            }
            
            System.Console.WriteLine("Enter a name");
            string name = Console.ReadLine();
             for( int j=0; j<=names.Length;j++)
            {
           
            if(name==names[j])
            {
                System.Console.WriteLine("The name is present in array");
                
                break;
            }
            else
            {
                if(count==4)
                {
                System.Console.WriteLine("The name is not present in array");
                count= count+1;
                }
            }
            
            }

            foreach( string name3 in names)
            {
               if(name==name3)
            {
                System.Console.WriteLine("The name is present in array");

                break;
            }
            else
            {
                System.Console.WriteLine("The name is not present in array");
            }
            }


        }
    }
}