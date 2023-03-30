using System;
namespace Question8;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Name1");
        string name1=Console.ReadLine();
        
        System.Console.WriteLine("Enter Name2");
        string name2=Console.ReadLine();
        
        int index=name1.IndexOf(" ");
        int index1=name2.IndexOf(" ");
        index=index < 0 ? 0 : index--;
        index1=index1 <0 ? 0 : index1--;

        int length = Math.Max(name1.Length,name2.Length);

        if(string.Compare(name1,index,name2,index1,length)<0)
        {
            System.Console.WriteLine(name1);
            System.Console.WriteLine(name2);
        }
        else
        {
            System.Console.WriteLine(name2);
            System.Console.WriteLine(name1);
        }
    }
}