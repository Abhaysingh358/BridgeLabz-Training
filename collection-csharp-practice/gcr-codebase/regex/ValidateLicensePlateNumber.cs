//Question->Validate a License Plate Number
//License plate format: Starts with two uppercase letters, followed by four digits.
//Example: "AB1234" is valid, but "A12345" is invalid.

using System.Text.RegularExpressions;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.regex
{
    internal class ValidateLicensePlateNumber
    {
        static bool IsValid(string licenseNumber)
        {
            string pattern = @"^[A-Z]{2}[0-9]{4}$";
            return Regex.IsMatch(licenseNumber, pattern);

        }

        static void Main(string[] args)
        {
            
            
                Console.Write("Enter License Number: ");
                string username = Console.ReadLine();

                if (IsValid(username))
                    Console.WriteLine("Valid");
                else
                    Console.WriteLine("Invalid");
            
        }
    }
}
