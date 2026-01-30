using System.Text;
using System.Text.RegularExpressions;

namespace LexicalTwist
{
    public class Requirements : IRequirements
    {
        public void IsSecondWordReversed()
        {
            Console.WriteLine("Enter the First Word : ");
            string word1 = Console.ReadLine();

            Console.WriteLine("Enter the Second word : ");
            string word2 = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(word1) || string.IsNullOrWhiteSpace(word2))
            {
                Console.WriteLine("String cannot be null or empty");
                 return;
            }

            // check validation that strings only contain one word
            if (!IsValidSingleWord(word1))
            {
                 Console.WriteLine($"{word1} is an invalid word");
                return;
            }

            if (!IsValidSingleWord(word2))
            {
                Console.WriteLine($"{word2} is an invalid word");
                return;
            }


            StringBuilder sb = new StringBuilder();

            for (int i = word2.Length - 1; i >= 0; i--)
            {
                sb.Append(word2[i]);
            }

                 string revWord2 = sb.ToString();
                
            if (word1.Equals(revWord2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Yes , The word is Reversed");
                // step1 . if second word is the reversed word of firstword we can also take the string and assign the value of second 
                // word but i use method to reverse the first word
                string revFirst = ReverseWord(word1);
                // step2. change it to lower cases
                revFirst = revFirst.ToLower();

                //step3. Replace the vowels of first reversed word with '@' , Step 4 . Print the Transform word used in replace method
                Replace(revFirst);
               

                return;
            }
            else{
            Console.WriteLine("second word is not reversed of first word");

            // 3. If the second word is not the reversed version of the first word:

            // - Step 1: Combine the first and second words into a single word (first word + second
            // word).

            string combined = String.Concat(word1 ," " , word2);

            // Step 2: Convert the combined word to uppercase.

            combined = combined.ToUpper();

            // step 3 to count vowels and consonants
            CountVowelsAndConsonants(combined);


            return;
            }
        } 

// step 1. reverse the first word if the second word is reversed of it
        public string ReverseWord(string word)
        {

            if (string.IsNullOrEmpty(word))
            {       
                Console.WriteLine("String is empty");
                return "";
            }

             // 1. Convert the string to a character array
            char[] charArray = word.ToCharArray();

            // 2. Reverse the array in place
            Array.Reverse(charArray);
            return new string(charArray);

        }  

// step 3 to replace vowel with '@' and Step4. print the Transformed word 
        public void Replace(string revWord)
        {
            string pattern = @"[aeiou]";
            string replacement = "@";

            string ans = Regex.Replace(revWord ,pattern,replacement);

            Console.WriteLine(ans);
        }


        // step 3. if words is not reversed of first
        public void CountVowelsAndConsonants(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                Console.WriteLine("String is empty");
                return;
            }

                string upperWord = word.ToUpperInvariant();

                HashSet<char> vowels = new HashSet<char> { 'A','E','I','O','U' };

                int vowelCount = 0;
                int consonantCount = 0;

            foreach (char c in upperWord)
            {
                if (char.IsLetter(c))
                {
                    if (vowels.Contains(c))
                        vowelCount++;
                    else
                        consonantCount++;
                }
            }

            if (vowelCount == consonantCount)
            {
                Console.WriteLine("Vowels and consonants are equal");
                return;
            }

            HashSet<char> seen = new HashSet<char>();
            List<char> result = new List<char>();

            foreach (char c in upperWord)
            {
                if (!char.IsLetter(c) || seen.Contains(c))
                continue;

            bool isVowel = vowels.Contains(c);

            if (vowelCount > consonantCount && isVowel)
            {
                result.Add(c);
                seen.Add(c);
            }
            else if (consonantCount > vowelCount && !isVowel)
            {
                result.Add(c);
                seen.Add(c);
            }

            if (result.Count == 2)
            break;
        }

        Console.WriteLine("Result: " + string.Join("", result));
    }

    // Validations using regex
    

    private bool IsValidSingleWord(string input)
    {
            if (string.IsNullOrWhiteSpace(input))
            return false;

        return Regex.IsMatch(input.Trim(), @"^[A-Za-z]+$");
    }


    }
}
