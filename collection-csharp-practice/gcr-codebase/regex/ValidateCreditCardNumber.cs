//Validate a Credit Card Number (Visa, MasterCard, etc.)
//A Visa card number starts with 4 and has 16 digits.
//A MasterCard starts with 5 and has 16 digits.

using System.Text.RegularExpressions;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.regex
{
    internal class ValidateCreditCardNumber
    {
        static bool IsValidCard(string cardNumber)
        {
            string pattern = @"^(4\d{15}|5\d{15})$";
            return Regex.IsMatch(cardNumber, pattern);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter credit card number: ");
            string cardNumber = Console.ReadLine();

            if (IsValidCard(cardNumber))
                Console.WriteLine("Valid Credit Card");
            else
                Console.WriteLine("Invalid Credit Card");
        }
    }
}
