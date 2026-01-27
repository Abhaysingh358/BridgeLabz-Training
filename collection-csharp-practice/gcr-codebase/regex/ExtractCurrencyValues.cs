//Extract Currency Values from a Text
//Example Text: "The price is $45.99, and the discount is $ 10.50."
//Expected Output:
//$45.99, 10.50

using System.Text.RegularExpressions;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.regex
{
    internal class ExtractCurrencyValues
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            string pattern = @"\$?\s?\d+(\.\d{2})?";

            MatchCollection matches = Regex.Matches(text, pattern);

            if (matches.Count == 0)
            {
                Console.WriteLine("No currency values found.");
            }
            else
            {
                Console.WriteLine("Extracted Currency Values:");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value.Trim());
                }
            }
        }
    }
}
