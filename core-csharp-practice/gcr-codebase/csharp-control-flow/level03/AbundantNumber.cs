using System;
class AbundantNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());

        int sum = 0;

         for (int i = 1; i < num; i++){
            if (num % i == 0)   // Check divisor 
            {
                sum += i;          // Add divisor to sum
            }
        }

        // check Abundant number condtion 
        if( sum > num)
        {
            Console.WriteLine(num + " is an Abundant Number");
        }
        else
        {
            Console.WriteLine(num + " is NOT an Abundant Number");
        }
    }
}