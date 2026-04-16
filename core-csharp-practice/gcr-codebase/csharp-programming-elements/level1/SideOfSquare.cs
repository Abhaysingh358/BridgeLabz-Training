using System;
class SideOfSquare
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the perimeter of the square:");
        double perimeter = double.Parse(Console.ReadLine());

        double sideLength = perimeter / 4;
        Console.WriteLine("The length of the side of the square with perimeter " + perimeter + " is: " + sideLength);
    }
}