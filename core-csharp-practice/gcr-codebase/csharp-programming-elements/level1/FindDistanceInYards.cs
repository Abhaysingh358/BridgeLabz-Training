using System;
class FindDistanceInYards
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the distance in feet:");
        double feet = double.Parse(Console.ReadLine());

        double yards = feet / 3;
        double miles = yards/1760;
        Console.WriteLine("The distance in yards is: " + yards +" yards");
        Console.WriteLine("The distance in miles is: " + miles +" miles");
    }
}