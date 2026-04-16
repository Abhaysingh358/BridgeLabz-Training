
using System.Text.RegularExpressions;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.regex
{
    internal class ExtractCapitalizedWords
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sentence: ");
            string text = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            if (matches.Count == 0)
            {
                Console.WriteLine("No capitalized words found.");
            }
            else
            {
                Console.WriteLine("Capitalized Words:");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
