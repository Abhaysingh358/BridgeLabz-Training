using System;
class SumUntilZero
{
    static void Main(string[] args)
    {
        double total = 0.0;
        Console.WriteLine("Enter a number and if you want to quit just enter 0: ");
        double value = double.Parse(Console.ReadLine());
        while(value != 0)
        {
            total += value;
            Console.WriteLine("Enter next number and if you want to quit just enter 0: ");
            value = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("The total sum is ->  " + total);

    }
}