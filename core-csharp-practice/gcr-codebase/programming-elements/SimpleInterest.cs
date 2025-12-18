using System;
public class SimpleInterest
{
    static void Main(string[] args)
    {
        // Ask the user to enter principal amount
        Console.Write("Enter principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        // Ask the user to enter rate of interest
        Console.Write("Enter rate of interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        // Ask the user to enter time in years
        Console.Write("Enter time in years: ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Formula to calculate simple interest
        // Simple Interest = (Principal × Rate × Time) / 100
        double simpleInterest = (principal * rate * time) / 100;

        // Display the calculated simple interest
        Console.WriteLine("Simple Interest is: " + simpleInterest);
    }
}