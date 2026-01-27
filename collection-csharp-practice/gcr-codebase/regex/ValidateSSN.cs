//Validate a Social Security Number (SSN)
//Example Input: "My SSN is 123-45-6789."
//Expected Output:
//✅ "123-45-6789" is valid
//❌ "123456789" is invalid

using System.Text.RegularExpressions;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.regex
{
    internal class ValidateSSN
    {
        static bool IsValidSSN(string text)
        {
            string pattern = @"\b\d{3}-\d{2}-\d{4}\b";
            return Regex.IsMatch(text, pattern);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter text containing SSN: ");
            string input = Console.ReadLine();

            if (IsValidSSN(input))
                Console.WriteLine("Valid SSN found");
            else
                Console.WriteLine("Invalid SSN format");
        }
    }
}
