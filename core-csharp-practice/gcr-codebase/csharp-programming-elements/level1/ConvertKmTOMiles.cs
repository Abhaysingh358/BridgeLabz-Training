using System;
class ConvertKmTOMiles
{
    static void Main(string[] args)
    {
        double km = double.Parse(Console.ReadLine());
        double miles = km * 0.621371;
        Console.WriteLine("The total miles is " + miles + " mile for the given " + km + " km");
    }
}