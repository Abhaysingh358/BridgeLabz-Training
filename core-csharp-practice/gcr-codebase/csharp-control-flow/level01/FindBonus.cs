// Create a program to find the bonus of employees based on their years of service.
// Hint => 
// Zara decided to give a bonus of 5% to employees whose year of service is more than 5 years.
// Take salary and year of service in the year as input.
// Print the bonus amount.

using System;
class FindBonus
{
    static void Main(string[] args)
    {
        // taking user input
        Console.WriteLine("Eneter the salary of the employee ");
        double salary  = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the years of service");
        double yearsOfService = double.Parse(Console.ReadLine());

        // using condition to caculate bonus
        if(yearsOfService > 5)
        {
            double bonus = salary * 0.05;
            Console.WriteLine("the bonus  " + bonus);
        }
        else
        {
            Console.WriteLine("No bonus");
        }
    
    }
}
