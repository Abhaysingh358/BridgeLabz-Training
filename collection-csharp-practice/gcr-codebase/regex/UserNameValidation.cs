using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.regex
{

    class UsernameValidator
    {
        static bool IsValidUsername(string username)
        {
            string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";
            return Regex.IsMatch(username, pattern);
        }

        static void Main()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            if (IsValidUsername(username))
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }

}
