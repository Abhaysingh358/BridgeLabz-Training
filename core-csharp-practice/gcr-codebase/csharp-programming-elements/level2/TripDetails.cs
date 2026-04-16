using System;
class TripDetails
{
    static void Main(string[] args)
    {
        // takin input of trip details from user
        Console.WriteLine("Enetr the Name of the City :");
        string cityName = Console.ReadLine();

        Console.WriteLine("Enetr the FromCity :");
        string fromCity = Console.ReadLine();

        Console.WriteLine("Enetr the ViaCity :");
        string viaCity = Console.ReadLine();

        Console.WriteLine("Enetr the ToCity :");
        string toCity = Console.ReadLine();

        Console.WriteLine("Enetr the Distance FromtoVia in miles:");
        double distanceFromToVia = double.Parse(Console.ReadLine());

        

        Console.WriteLine("Enter the Distance ViaTOFinalCity in miles :" );
        double distanceViaToFinalCity = double.Parse(Console.ReadLine());

    // taking input of time taken in the journey
        Console.WriteLine("Enter the Time taken in the journey in hours :" );
        double timeTaken = double.Parse(Console.ReadLine());

        // calculating distance and speed of the journey
        double totalDistance = distanceFromToVia + distanceViaToFinalCity;

        double speed = totalDistance / timeTaken;
        Console.WriteLine("The Trip Details are as follows: ");
        Console.WriteLine("City Name: " + cityName);
        Console.WriteLine("From City: " + fromCity);
        Console.WriteLine("Via City: " + viaCity);
        Console.WriteLine("To City: " + toCity);

        Console.WriteLine("Total Distance Travelled: " + totalDistance + " miles");
        Console.WriteLine("Time Taken: " + timeTaken + " hours");
        Console.WriteLine("Average Speed: " + speed + " miles/hour");
       
    }
}
       
  