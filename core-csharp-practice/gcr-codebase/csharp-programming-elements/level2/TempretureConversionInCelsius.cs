using System;
class TempretureConversionInCelsius
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the temperature in Fahrenheit:");
        double fahrenheit = double.Parse(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine("The temperature in Celsius is: " + celsius + " celsius");
    }
}