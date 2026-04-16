using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.extras_csharp_strings.level01
{
    internal class NumberGuessing
    {
        static Random random = new Random();
        static int GeneratedNum = 0; // set static so that it is used to store generated number

        // created a method to generate a random integer between 1 to 100
        public static int GenerateNumber()
        {

            GeneratedNum = random.Next(1, 101); // generates a random number between 1 and 100
            return GeneratedNum;


        }

        // method to guess the number and return the status high , low, correct
        public static int Guess(int guess)
        {
            if (guess == GeneratedNum)
            {
                return 0; // correct
            }
            else if (guess > GeneratedNum)
            {
                return 1; // guess higher
            }
            else
            {
                return -1; //  guess lower
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 100 :");
            Console.WriteLine("The number of guesses you want ");
            int num = int.Parse(Console.ReadLine());

            // calling methods to generate number
            GenerateNumber();

            // whule loop to take user input and implemnt the methods
            int i = 1;
            while (i <= num)
            {
                Console.WriteLine("Guess the Number ");
                int n = int.Parse(Console.ReadLine());

                int res = Guess(n);
                // calling methods to guess number and using return int to compare whether it is high ,low or equal
                if (i <= 3)
                {
                    if (res == 0)
                    {
                        Console.WriteLine(" Correct ! : Your Daddy must be Proud");
                        return;
                    }
                }

                if (res == 0)
                {
                    Console.WriteLine("Correct");
                    Console.WriteLine($"Guesses reamaining : {num - i}");
                    return;
                }
                else if (res > 0)
                {
                    Console.WriteLine("Guess a lower Number");
                    Console.WriteLine($"Guesses reamaining : {num - i}");
                }
                else
                {
                    Console.WriteLine("Guess a higher number ");
                    Console.WriteLine($"Guesses reamaining : {num - i}");
                }
                i++;


            }

            Console.WriteLine($"The generated Number is : {GeneratedNum}");

        }

    }
}
