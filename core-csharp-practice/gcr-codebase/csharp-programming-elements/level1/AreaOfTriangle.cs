using System;
class AreaOfTriangle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the base value of triangle :");
        float baseValue = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height value of triangle :");
        float height = float.Parse(Console.ReadLine());

        float area = 0.5f * baseValue * height;
        Console.WriteLine("The area of triangle with base " + baseValue + " and height " + height + " is : " + area);

    }
}