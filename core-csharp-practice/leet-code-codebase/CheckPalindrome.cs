using System;

public class CheckPalindrome
{
    public static void Main(string[] args)
    {
        // Equivalent to Scanner in Java
        string input = Console.ReadLine();
        int n = int.Parse(input);

        bool isPalindrome = true;

        for (int i = 2; i <= n / 2; i++)
        {
            if (n % 2 == 0) // Note: This check makes any even number 'false'
            {
                isPalindrome = false;
                return; 
            }
        }

        Console.WriteLine("number is Palindrome " + isPalindrome.ToString().ToLower());
    }
}