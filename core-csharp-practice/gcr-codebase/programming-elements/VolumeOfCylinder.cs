using System;
public class volumeOfCylinder
{
    static void Main(string[] args)
    {
        // Ask the user to enter the radius of the cylinder
        Console.Write("Enter the radius of the cylinder: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Ask the user to enter the height of the cylinder
        Console.Write("Enter the height of the cylinder: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Formula to calculate volume of a cylinder
        // Volume = π × radius x radius × height
        double volume = Math.PI * Math.Pow(radius, 2) * height;

        // Display the calculated volume
        Console.WriteLine("Volume of the cylinder is: " + volume);
    }
}