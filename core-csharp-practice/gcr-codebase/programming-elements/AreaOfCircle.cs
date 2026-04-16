using System;

class areaofcircle
{
    static void Main(string[] args)
    {
        // Ask the user to enter the radius of the circle
        Console.Write(" enetr the radius of the circle: ");

        // Read input from the user
        double radius = Convert.ToDouble(Console.ReadLine());

        // Formula to calculate area of a circle
        // Area = π × radius × radius
        double area = Math.PI * radius * radius;

        // Display the calculated area
        Console.WriteLine("Area of the circle is: " + area);
    }
}
