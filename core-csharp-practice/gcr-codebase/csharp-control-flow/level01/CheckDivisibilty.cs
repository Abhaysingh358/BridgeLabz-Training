using System;

class CheckDivisibilty
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int num = int.Parse(Console.ReadLine());
        if(num % 5 == 0)
        {
            Console.WriteLine("number is divisible by 5");
        }
        else
        {
            Console.WriteLine("number is not divisible by 5");
        }
        }
}