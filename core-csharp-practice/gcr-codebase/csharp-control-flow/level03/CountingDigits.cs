using System;

class CountingDigits
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        int count = 0;

        // Convert to positive if number is negative
        number = Math.Abs(number);

        // Special case: number = 0
        if (number == 0){
        
            count = 1;
        }
        else{
            while (number != 0)
            {
                number /= 10;  // this is Removing last digit
                count++;       // Increase count plus one
            }
        }

        Console.WriteLine("Number of digits : " + count);
    }
}
