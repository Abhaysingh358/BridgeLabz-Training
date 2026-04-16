using System;
using System.Runtime.InteropServices;
class FizzBuzz
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enetr the NUmber");
        int num = int.Parse(Console.ReadLine());

        if(num <= 0)
        {
            Console.WriteLine("Only number is valid grater than 0");
            return;
        }

        for(int i = 1; i<=num; i++)
        {
            if(i%3 == 0 && i%5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if(i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}