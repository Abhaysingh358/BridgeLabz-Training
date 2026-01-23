using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.Exceptions
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    class AgeValidationApp
    {
        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be 18 or above");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your age: ");
                int userAge = Convert.ToInt32(Console.ReadLine());

                ValidateAge(userAge);

                Console.WriteLine("Access granted!");
            }
            catch (InvalidAgeException)
            {
                Console.WriteLine("Age must be 18 or above");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid numeric age.");
            }
        }
    }

}
