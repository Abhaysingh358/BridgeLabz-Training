//Extract Links from a Web Page
//Example Text: "Visit https://www.google.com and http://example.org for more info."
//Expected Output:
//https://www.google.com, http://example.org



using System.Text.RegularExpressions;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.regex
{
    internal class ExtractLinksFromText
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            string pattern = @"https?:\/\/[^\s]+";

            MatchCollection matches = Regex.Matches(text, pattern);

            if (matches.Count == 0)
            {
                Console.WriteLine("No links found.");
            }
            else
            {
                Console.WriteLine("Extracted Links:");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
