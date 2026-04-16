using System;
class SumUntilNegativeOrZero
{
    static void Main(string[] args)
    {
        double total = 0.0;
        Console.WriteLine("Enter a number and if you want to quit just enter 0 or a negative number: ");
        double value = double.Parse(Console.ReadLine());
        //  always take inputs until a negative number or zero is entered
        while(value > 0)
        {
            total += value;
            Console.WriteLine("Enter next number and if you want to quit just enter 0 or a negative number: ");
            value = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("The total sum is ->  " + total);
    }
}