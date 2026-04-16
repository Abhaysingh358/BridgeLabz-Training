using System;
using System.Runtime.InteropServices;
class FizzBuzzUsingWhile
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


        int i = 1;
        while(i<=num)
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
            i++;
        }
    }
}