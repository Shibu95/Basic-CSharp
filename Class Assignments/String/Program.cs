using System;
namespace String
{
    class Program 
    {
        public static void Main(string[] args)
        {
            /*System.Console.WriteLine("Main String");
            string letters=Console.ReadLine();
            
            System.Console.WriteLine("String to be searched");
            string letters1=Console.ReadLine();
            
            string[] subdata=letters.Split(letters1, StringSplitOptions.RemoveEmptyEntries);
            System.Console.WriteLine(subdata.Length);*/

            Console.WriteLine("Date(dd/mm/yyyy):");
            DateTime date;
            bool checkDate = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out date);
            while (!checkDate) {
                Console.WriteLine("You have entered a invalid date.. Please enter a valid format(dd/MM/yyyy)");
                checkDate = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out date);
            }
            Console.WriteLine(checkDate + " " + date);

        }
    }
}