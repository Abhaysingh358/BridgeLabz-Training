using System;
class CalculateRounds
{
    static void Main(string[] args)
    {
        // taking input of all three side by the user
        Console.WriteLine("Enter the lengths of side1 of the triangle:");
        double side1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the lengths of side2 of the triangle:");
        double side2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the lengths of side3 of the triangle:");
        double side3 = double.Parse(Console.ReadLine());
        
        // calcualting the perimetrs of the triangle
        double perimeter = side1 + side2 + side3;
        Console.WriteLine("Perimeter of the triangle is: " + perimeter);

        // convert the given 5km to meters as 1 km = 1000 meters
        double coveredDistance = 5 * 1000;
        // calculating the number of rounds
        double totalRounds = coveredDistance / perimeter;
        Console.WriteLine("The total number of rounds the athlete will run is " + totalRounds);
    }
}