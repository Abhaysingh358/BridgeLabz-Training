using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level01
{
    internal class SplitTextInToWords
    {
        public static int length(string s)
        {
            if(s == null)
            {
                return 0;
            }
            int count = 0;
            s = s.Trim();
            foreach (char c in s)
            {
                count++;
            }
            return count;
        }

        public static string[][] split(string s)
        {
            if (s == null)
            {
                return new string[0][];
            }
            // Trim leading and trailing spaces
            s = s.Trim();
            int len = length(s);
            int count = 0;
            string word = "";

            // First, count the number of words
            for (int i = 0; i < len; i++)
            {
                if (s[i] == ' ')
                {
                    
                    if (length(word) > 0)
                    {
                        count++;
                        word = "";
                    }
                }
                else
                {
                    // build the current word
                    word += s[i];

                }

            
            // if the last word is not empty
            if (i == len - 1 && length(word) > 0)
            {
                count++;
            }
        }

                string[][] result = new string[count][];

                int idx = 0;
                word = "";
                for (int i = 0; i < len; i++)
                {
                // build words and store in result
                if (s[i] == ' ')
                    {
                        if(length(word) > 0)
                        {
                        // store the word in result
                        result[idx] = new string[length(word)];
                            for (int j = 0; j < length(word); j++)
                            {
                                result[idx][j] = word[j].ToString(); // Convert char to string
                        }
                            idx++;
                            word = ""; // reset word for next
                    }
                    }
                    else
                    {
                        word += s[i];
                    }
                    // if the last word is not empty
                    if(i == len - 1 && length(word) > 0)
                    {
                        result[idx] = new string[length(word)];
                        for (int j = 0; j < length(word); j++)
                        {
                            result[idx][j] = word[j].ToString();
                        }
                    }
                }
                return result;


         }

        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            // 
            // Split the string into words
            string[][] words = split(s);

            // displaying  the words
            int len = words.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    Console.Write(words[i][j]); // Print each character of the word
                }
                Console.WriteLine();
            }


        }




    }

}

