using System;

class GreatestFactor
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number:");
        int num = int.Parse(Console.ReadLine());

        int greatestFactor = 1; // always a default smallest factor

        // number - 1 and  to 1
        for (int i = num - 1; i>= 1; i--)
        {
            if (num%i == 0)   // Check the perfect divisibility
            {
                greatestFactor = i;
                break;  // Stop immediately, since we found the greatest factor
            }
        }

        Console.WriteLine("The greatest factor of " + num + " (besides itself) is: " + greatestFactor);
    }
}
