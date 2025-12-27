using System;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_strings.level01
{
    internal class ReturnCharacters
    {
        // Method to print/return all characters without using char[]
        public static void ReturnChars(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("String is empty.");
                return;
            }

           

            Console.WriteLine("All characters:");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string s = Console.ReadLine();

            ReturnChars(s);
        }
    }
}
