
using System.Text.RegularExpressions;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.regex
{
    internal class NormalizeSpaces
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            string pattern = @"\s+";

            string result = Regex.Replace(text, pattern, " ");

            Console.WriteLine("After cleanup:");
            Console.WriteLine(result);
        }
    }
}
