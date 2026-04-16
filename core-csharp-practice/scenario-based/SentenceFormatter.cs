using System;
using System.Text;

namespace BridgeLabz.core_csharp_practice.scenerio_based
{
    internal class SentenceFormatter
    {
        private string AddSpace(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                sb.Append(s[i]);

                if (s[i] == '.' || s[i] == ',' || s[i] == '?' || s[i] == '!' || s[i] == ':')
                {
                    // ensure not out-of-range and next char is not space
                    if (i + 1 < s.Length && s[i + 1] != ' ')
                        sb.Append(' ');
                }
            }

            return sb.ToString();
        }

        private string Capital(string s)
        {
            StringBuilder sb = new StringBuilder();
            bool newSentence = true;

            for (int i = 0; i < s.Length; i++)
            {
                if (newSentence && char.IsLetter(s[i]))
                {
                    sb.Append(char.ToUpper(s[i]));
                    newSentence = false;
                }
                else
                {
                    sb.Append(s[i]);
                }

                if (s[i] == '.' || s[i] == '?' || s[i] == '!')
                    newSentence = true;
            }

            return sb.ToString();
        }

        private string TrimExtraSpace(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            StringBuilder sb = new StringBuilder();
            bool spaceSeen = false;
            int i = 0;

            while (i < s.Length && s[i] == ' ')
                i++;

            for (; i < s.Length; i++)
            {
                char c = s[i];

                if (c == ' ')
                {
                    spaceSeen = true;
                }
                else
                {
                    if (spaceSeen && sb.Length > 0)
                        sb.Append(' ');

                    sb.Append(c);
                    spaceSeen = false;
                }
            }

            return sb.ToString();
        }

        public static string LongestWord(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return "";

            string[] words = s.Split(' ');
            string longestWord = "";

            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                    longestWord = word;
            }

            return longestWord;
        }

        private int CountWords(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;

            string[] words = s.Split(' ');
            int count = 0;

            foreach (string w in words)
            {
                if (!string.IsNullOrWhiteSpace(w))
                    count++;
            }

            return count;
        }

        private string ReplaceWord(string text, string oldWord, string newWord)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].ToLower() == oldWord.ToLower())
                    words[i] = newWord;
            }

            return string.Join(" ", words);
        }

        public void ProcessParagraph()
        {
            Console.WriteLine("Enter a paragraph:");
            string paragraph = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(paragraph))
            {
                Console.WriteLine("Invalid paragraph.");
                return;
            }

            // apply formatting
            string formatted = TrimExtraSpace(paragraph);
            formatted = AddSpace(formatted);
            formatted = Capital(formatted);

            Console.WriteLine("Word count: " + CountWords(formatted));
            Console.WriteLine("Longest word: " + LongestWord(formatted));

            Console.WriteLine("Enter word to replace:");
            string oldWord = Console.ReadLine();

            Console.WriteLine("Enter new word:");
            string newWord = Console.ReadLine();

            string replaced = ReplaceWord(formatted, oldWord, newWord);

            Console.WriteLine("After replacement:");
            Console.WriteLine(replaced);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SentenceFormatter formatter = new SentenceFormatter();
            formatter.ProcessParagraph();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
