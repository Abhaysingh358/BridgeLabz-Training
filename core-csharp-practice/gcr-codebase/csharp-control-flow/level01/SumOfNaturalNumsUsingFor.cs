using System;
class SumOfNaturalNumsUsingFor
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Number up to which you want to sum");
        int num = int.Parse(Console.ReadLine());
        int sum = 0;

        // using while loop to calculate the sum of natural numsers up to num
        for(int i = 1; i <= num; i++)
        {
            sum+=i;
        }

        // by the formula n(n+1)/2
        int sumByFormula = (num * (num + 1)) / 2;
        if(sum == sumByFormula)
        {
            Console.WriteLine("The sum of first {0} natural numbers using loop is {1}", num, sum);
            Console.WriteLine("The sum of first {0} natural numbers using formula is {1}", num, sumByFormula);
        }
        else
        {
            Console.WriteLine("There is a discrepancy in the calculations.");
        }

    }
}