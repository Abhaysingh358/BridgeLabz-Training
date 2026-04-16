using System;
class TempretureConversion
{
    static void Main(string[] args)
    {
        // take input of the temp in celsius
        Console.WriteLine("Enter the temperature in Celsius:");
        double celsius = double.Parse(Console.ReadLine());
        // convert celsius to fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;
        // print the result
        Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheit + " fahrenheit");
    }
}