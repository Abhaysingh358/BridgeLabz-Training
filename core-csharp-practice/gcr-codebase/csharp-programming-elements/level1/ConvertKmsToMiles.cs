using System;
public class ConvertKmsToMiles
{
    static void Main(string[] args)
    {
        double distance = 10.8;//in kilometers
        double miles = distance * 0.621371; //conversion factor
        Console.WriteLine("The distance " + distance + " km in miles is " + miles);


    }
}