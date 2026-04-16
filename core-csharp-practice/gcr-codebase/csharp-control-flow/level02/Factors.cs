using System;

class Factors
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Factors of " + number + " are:");


        // Loop runs from 1 up to number-1
        for (int i = 1; i < number; i++)
        {
            // Check if i divides the number completely
            if (number % i == 0)
            {
                
                Console.WriteLine(i);
            }
        }
    }
}
