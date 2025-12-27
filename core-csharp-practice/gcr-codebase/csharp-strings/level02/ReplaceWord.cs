using System;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level02
{
    internal class ReplaceWord
    {
        // Method to replace a word manually
        public static string ToReplaceWord(string sentence, string oldWord, string newWord)
        {
            if (string.IsNullOrEmpty(sentence) ||
                string.IsNullOrEmpty(oldWord) ||
                newWord == null)
            {
                return sentence;
            }

            string result = "";
            string currentWord = "";

            for (int i = 0; i < sentence.Length; i++)
            {
                char c = sentence[i];

                if (c != ' ')
                {
                    currentWord += c;   // build the word
                }
                else
                {
                    // Compare built word with target word
                    if (currentWord == oldWord)
                        result += newWord;
                    else
                        result += currentWord;

                    result += " "; // add the space back
                    currentWord = "";
                }
            }

            // Handle last word (after loop)
            if (currentWord == oldWord)
                result += newWord;
            else
                result += currentWord;

            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            Console.WriteLine("Enter word to replace:");
            string oldWord = Console.ReadLine();

            Console.WriteLine("Enter new word:");
            string newWord = Console.ReadLine();

            string updatedSentence = ToReplaceWord(sentence, oldWord, newWord);

            Console.WriteLine("Updated Sentence:");
            Console.WriteLine(updatedSentence);
        }
    }
}
