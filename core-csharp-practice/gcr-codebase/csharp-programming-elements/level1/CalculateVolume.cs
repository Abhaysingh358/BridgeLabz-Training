using System;
class CalculateVolume
{
    static void Main(string[] args)
    {
        double radiusOfEarth = 6378; // in kilometers
        double volume = (4/ 3) * Math.PI * Math.Pow(radiusOfEarth, 3);
       
    // Convert volume to cubic miles
        double radiusInMiles = radiusOfEarth * 0.621371; // converting radius to miles
        double volumeInMiles = (4 / 3) * Math.PI * Math.Pow(radiusInMiles, 3);
       
       Console.WriteLine("The volume of earth in cubic kilometers is " + volume + " and cubic miles is " + volumeInMiles);
    }
}