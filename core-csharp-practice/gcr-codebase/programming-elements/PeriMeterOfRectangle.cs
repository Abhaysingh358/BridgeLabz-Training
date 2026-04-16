using System;
public class PeriMeterOfRectangle
{
    static void Main(string[] args)
    {
        // Ask the user to enter the length of the rectangle
        Console.Write("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        // Ask the user to enter the width of the rectangle
        Console.Write("Enter the width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        // Formula to calculate perimeter of a rectangle
        // Perimeter = 2 × (length + width)
        double perimeter = 2 * (length + width);

        // Display the calculated perimeter
        Console.WriteLine("Perimeter of the rectangle is: " + perimeter);
    }
}