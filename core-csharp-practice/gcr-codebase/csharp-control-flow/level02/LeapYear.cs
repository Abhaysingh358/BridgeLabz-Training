using System;
class LeapYear
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the year");
        int year = int.Parse(Console.ReadLine());
        // according to georgian calendar logic is built below.
        if (year < 1582)
        {
            Console.WriteLine("Please enter a year greater than 1582");
        }

        // all conditoins in one if using logical operators
        else if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
        {
            Console.WriteLine("It is a leap year");
        }
        else
        {
            Console.WriteLine("It is not a leap year");
        }
    }
}