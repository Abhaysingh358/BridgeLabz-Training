//Extract Programming Language Names from a Text
//Example Text: "I love Java, Python, and JavaScript, but I haven't tried Go yet."
//Expected Output:
//Java, Python, JavaScript, Go

using System.Text.RegularExpressions;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.regex
{
    internal class ExtractProgrammingLanguages
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            string[] languages = { "Java", "Python", "JavaScript", "Go", "C", "CSharp", "PHP", "Ruby" };

            string pattern = @"\b(" + string.Join("|", languages) + @")\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            if (matches.Count == 0)
            {
                Console.WriteLine("No programming languages found.");
            }
            else
            {
                Console.WriteLine("Extracted Languages:");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
