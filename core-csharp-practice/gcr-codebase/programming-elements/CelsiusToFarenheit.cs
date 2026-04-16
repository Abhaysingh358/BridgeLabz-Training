using System;

public class CelsiusTOFarenheit
{
    static void Main(string[] args)
    {
        // Ask the user to enter temperature in Celsius
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Formula to convert Celsius to Fahrenheit
        // Fahrenheit = (Celsius × 9/5) + 32
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Display the converted temperature
        Console.WriteLine("Temperature in the Fahrenheit: " + fahrenheit);
    }
}
