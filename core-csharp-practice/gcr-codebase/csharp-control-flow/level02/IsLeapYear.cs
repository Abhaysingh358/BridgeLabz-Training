using System;
class IsLeapYear
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enetr the Year ");
        int year = int.Parse(Console.ReadLine());

        // in  georgian calendar leap year works if year is greater than 1582
        if(year < 1582)
        {
           Console.WriteLine("Please enter the greater than 1582");
        }
        else
        {
            //  if it is divisible by 400 then it is leap year
            // if it is divisible by 100 then it is not a leap year
            // if it is divisible by 4 then it is a leap year
            
            if(year % 400 == 0)
            {
                Console.WriteLine("It is a leap year");
            }
            else if(year % 100 == 0)
            {
                Console.WriteLine("It is not a leap year");
            }
            else if(year % 4 == 0)
            {
                Console.WriteLine("It is a leap year");
            }
            else
            {
                Console.WriteLine("It is not a leap year");
            }
        }
    }
}