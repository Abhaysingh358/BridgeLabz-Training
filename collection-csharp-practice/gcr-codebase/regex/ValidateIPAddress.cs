//Validate an IP Address
//A valid IPv4 address consists of four groups of numbers (0-255) separated by dots.


using System.Text.RegularExpressions;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.regex
{
    internal class ValidateIPAddress
    {
        static bool IsValidIP(string ip)
        {
            string pattern = @"^(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}$";
            return Regex.IsMatch(ip, pattern);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter IP address: ");
            string ip = Console.ReadLine();

            if (IsValidIP(ip))
                Console.WriteLine("Valid IP Address");
            else
                Console.WriteLine("Invalid IP Address");
        }
    }
}
