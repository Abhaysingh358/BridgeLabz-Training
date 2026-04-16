//Question -> Validate a Hex Color Code
//A valid hex color:
//Starts with a #
//Followed by 6 hexadecimal characters (0-9, A-F, a-f).
//Example Inputs & Outputs:
//✅ "#FFA500" → Valid
//✅ "#ff4500" → Valid
//❌ "#123" → Invalid (too short)


using System.Text.RegularExpressions;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.regex
{
    internal class ValidateHexColorCode
    {
        static bool IsValid(string colorCode)
        {
            string pattern = @"^#[0-9A-Fa-f]{6}$";
            return Regex.IsMatch(colorCode, pattern);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter Hex Color Code: ");
            string colorCode = Console.ReadLine();

            if (IsValid(colorCode))
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}

