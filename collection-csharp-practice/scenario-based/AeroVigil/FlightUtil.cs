
using System.Text.RegularExpressions;

namespace AeroVigil{
public class FlightUtil
{
    public bool ValidateFlightNumber(string flightNumber)
    {
        if (!Regex.IsMatch(flightNumber, "^FL-[1-9][0-9]{3}$"))
        {
            throw new InvalidFlightException(
                "The flight number " + flightNumber + " is invalid"
            );
        }

        return true;
    }

    public bool ValidateFlightName(string flightName)
    {
        if (!(flightName.Equals("SpiceJet", StringComparison.OrdinalIgnoreCase) ||
              flightName.Equals("Vistara", StringComparison.OrdinalIgnoreCase) ||
              flightName.Equals("IndiGo", StringComparison.OrdinalIgnoreCase) ||
              flightName.Equals("Air Arabia", StringComparison.OrdinalIgnoreCase)))
        {
            throw new InvalidFlightException(
                "The flight name " + flightName + " is invalid"
            );
        }

        return true;
    }

    public bool ValidatePassengerCount(int passengerCount, string flightName)
    {
        int maxCapacity = GetPassengerCapacity(flightName);

        if (passengerCount <= 0 || passengerCount > maxCapacity)
        {
            throw new InvalidFlightException(
                "The passenger count " + passengerCount + " is invalid for " + flightName
            );
        }

        return true;
    }

    public double CalculateFuelToFillTank(string flightName, double currentFuelLevel)
    {
        double maxFuel = GetFuelCapacity(flightName);

        if (currentFuelLevel < 0 || currentFuelLevel > maxFuel)
        {
            throw new InvalidFlightException(
                "Invalid fuel level for " + flightName
            );
        }

        return maxFuel - currentFuelLevel;
    }

    // ---------------- Helper Methods ----------------

    private int GetPassengerCapacity(string flightName)
    {
        switch (flightName)
        {
            case "SpiceJet":
                return 396;

            case "Vistara":
                return 615;

            case "IndiGo":
                return 230;

            case "Air Arabia":
                return 130;

            default:
                return 0;
        }
    }

    private double GetFuelCapacity(string flightName)
    {
        switch (flightName)
        {
            case "SpiceJet":
                return 200000;

            case "Vistara":
                return 300000;

            case "IndiGo":
                return 250000;

            case "Air Arabia":
                return 150000;

            default:
                return 0;
        }
    }
}
}
