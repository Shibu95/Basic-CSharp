using System;
namespace Question10
{
    class Program 
    {
        public static void Main(string[] args)
            {
                System.Console.WriteLine("Input");
                int number = int.Parse(Console.ReadLine());

                string text="";

                

                Program result = new Program();
                text=result.OneToHundred(number);

                
                System.Console.WriteLine(text);
            }
        string OneToHundred(int number)
        {
            
            string text ="";

            while(number>0)
            {
                if(number==1)
                {
                    text+="one";
                    number=0;
                }
                else if(number==2)
                {
                    text+="two";
                    number=0;
                }
                else if(number==3)
                {
                    text+="three";
                    number=0;
                }
                else if(number==4)
                {
                    text+="four";
                    number=0;
                }
                else if(number==5)
                {
                    text+="five";
                    number=0;
                }
                else if(number==6)
                {
                    text+="six";
                    number=0;
                }
                else if(number==7)
                {
                    text+="seven";
                    number=0;
                }
                else if(number==8)
                {
                    text+="eight";
                    number=0;
                }
                else if(number==9)
                {
                    text+="nine";
                    number=0;
                }
                else if(number==10)
                {
                    text+="ten";
                    number=0;
                }
                else if(number==11)
                {
                    text+="eleven";
                    number=0;
                }
                else if(number==12)
                {
                    text+="twelve";
                    number=0;
                }
                else if(number==13)
                {
                    text+="thirteen";
                    number=0;
                }
                else if(number==14)
                {
                    text+="fourteen";
                    number=0;
                }
                else if(number==15)
                {
                    text+="fifteen";
                    number=0;
                }
                else if(number==16)
                {
                    text+="sixteen";
                    number=0;
                }
                else if(number==17)
                {
                    text+="seventeen";
                    number=0;
                }
                else if(number==18)
                {
                    text+="eighteen";
                    number=0;
                }
                else if(number==19)
                {
                    text+="nineteen";
                    number=0;
                }
                else if(number>=20 && number<30)
                {
                    text+="twenty";
                    number=number-20;
                }
                else if(number>=30 && number<40)
                {
                    text+="thirty";
                    number=number-30;
                }
                else if(number>=40 && number<50)
                {
                    text+="forty";
                    number=number-40;
                }
                else if(number>=50 && number<60)
                {
                    text+="fifty";
                    number=number-50;
                }
                else if(number>=60 && number<70)
                {
                    text+="sixty";
                    number=number-60;
                }
                else if(number>=70 && number<80)
                {
                    text+="seventy";
                    number=number-70;
                }
                else if(number>=80 && number<90)
                {
                    text+="eighty";
                    number=number-80;
                }
                else if(number>=90 && number<100)
                {
                    text+="ninety";
                    number=number-90;
                }
            }
            return text;

           

        }
    }
}