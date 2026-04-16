using System;
class CheckSpringSeason
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enetr the Month number from 1 to 12");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("enetr the day number from 1 to 31");
        int day = int.Parse(Console.ReadLine());
        if(month ==3 && day >= 20 && day <= 31 
        || month ==4 && day >=1 && day <=30
        || month ==5 && day >=1 && day <=31
        || month ==6 && day >=1 && day <=20)
        {
            Console.WriteLine("it's a spring season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}