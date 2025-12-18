using System;
public class ConvertKmTOMile
{
    static void Main(string[] args)
    {
        // Ask the user to enter distance in kilometers
        Console.Write("Enter distance in kilometers: ");
        double kilometers = Convert.ToDouble(Console.ReadLine());

        // Formula to convert kilometers to miles
        // Miles = Kilometers × 0.621371
        double miles = kilometers * 0.621371;

        // Display the converted distance
        Console.WriteLine("Distance in miles: " + miles);
    }
}