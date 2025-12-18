using System;
public class PowerCalculation
{
    static void Main(string[] args)
    {
        // Ask the user to enter the base number
        Console.Write("Enter the base number: ");
        double baseNum = Convert.ToDouble(Console.ReadLine());

        // Ask the user to enter the exponent
        Console.Write("Enter the exponent: ");
        double exponent = Convert.ToDouble(Console.ReadLine());

        // Formula to calculate power
        // Power = base^exponent
        double power = Math.Pow(baseNum, exponent);

        // Display the calculated power
        Console.WriteLine(baseNum + " raised to the power of " + exponent + " is: " + power);
    }
}