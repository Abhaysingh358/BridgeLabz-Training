using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.PasswordCracker
{
    using System;

    class PasswordCrackerMain
    {
        static string password;
        static bool found = false;

        // ALL chars = 0-9 + a-z + A-Z
        static char[] chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        static void Main()
        {
            Console.Write("Enter password: ");
            password = Console.ReadLine();

            char[] arr = new char[password.Length];

            Crack(0, arr);

            if (!found)
                Console.WriteLine("Password not found.");
        }

        static void Crack(int index, char[] arr)
        {
            if (found) return;

            if (index == arr.Length)
            {
                string guess = new string(arr);

                if (guess == password)
                {
                    Console.WriteLine("Password cracked: " + guess);
                    found = true;
                }
                return;
            }

            for (int i = 0; i < chars.Length; i++)
            {
                arr[index] = chars[i];
                Crack(index + 1, arr);
            }
        }
    }

}
