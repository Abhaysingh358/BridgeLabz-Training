//Extract Dates in dd/mm/yyyy Format
//Example Text: "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020."
//Expected Output:
//12 / 05 / 2023, 15 / 08 / 2024, 29 / 02 / 2020



using System.Text.RegularExpressions;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.regex
{
    internal class ExtractDatesFromText
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            string pattern = @"\b\d{2}/\d{2}/\d{4}\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            if (matches.Count == 0)
            {
                Console.WriteLine("No dates found.");
            }
            else
            {
                Console.WriteLine("Extracted Dates:");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
