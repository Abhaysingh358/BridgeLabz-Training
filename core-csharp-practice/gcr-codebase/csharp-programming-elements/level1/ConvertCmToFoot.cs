using System;
class ConvertCmToFoot
{
    static void Main(string[] args)
    {
        Console.Write("Enter height in centimeters: ");
        double heightInCm = double.Parse(Console.ReadLine()); // height in centimeters

        
        double heightInInches = heightInCm / 2.54; // conversion factor
        double heightInFeet = heightInInches / 12; // conversion factor

        Console.WriteLine("Your Height in cm is " + heightInCm + " while in feet is " + heightInFeet + " and inches is " + heightInInches);
    }
}