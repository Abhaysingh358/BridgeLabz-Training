//Censor Bad Words in a Sentence
//Given a list of bad words, replace them with ****.
//Example Input: "This is a damn bad example with some stupid words."
//Expected Output: "This is a **** bad example with some **** words."

using System.Text.RegularExpressions;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.regex
{
    internal class CensorBadWords
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sentence: ");
            string text = Console.ReadLine();

            string[] badWords = { "damn", "stupid" };

            string pattern = @"\b(" + string.Join("|", badWords) + @")\b";

            string result = Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);

            Console.WriteLine("Censored Output:");
            Console.WriteLine(result);
        }
    }
}

