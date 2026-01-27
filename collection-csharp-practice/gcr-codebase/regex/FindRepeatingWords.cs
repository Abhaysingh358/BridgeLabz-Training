//Find Repeating Words in a Sentence
//Example Input: "This is is a repeated repeated word test."
//Expected Output:
//is, repeated

using System.Text.RegularExpressions;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.regex
{
    internal class FindRepeatingWords
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sentence: ");
            string text = Console.ReadLine();

            string pattern = @"\b(\w+)\s+\1\b";

            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

            if (matches.Count == 0)
            {
                Console.WriteLine("No repeating words found.");
            }
            else
            {
                Console.WriteLine("Repeating Words:");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Groups[1].Value);
                }
            }
        }
    }
}
