using System;
using System.Text.RegularExpressions;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.regex
{
    internal class ExtractEmailsFromText
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            string pattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}";

            MatchCollection matches = Regex.Matches(text, pattern);

            if (matches.Count == 0)
            {
                Console.WriteLine("No email addresses found.");
            }
            else
            {
                Console.WriteLine("Extracted Emails:");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
