using System;
class CalculateSimpleInterest
{
    static void Main(string[] args)
    {
        // takin input form user
        Console.WriteLine("Enter Principle amount :");
        double principle = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the rate:");
        double rate = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the time in years:");
        double time = double.Parse(Console.ReadLine());

        // Calculate Simple Interest
        double simpleInterest = (principle * rate * time) / 100;
        Console.WriteLine("The Simple Interest is: " + simpleInterest + " for Principle : " + principle + ", Rate of Interest " + rate + "% and Time " + time + " years.");
    }
}