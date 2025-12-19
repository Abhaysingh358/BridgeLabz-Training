using System;
class TotalIncome
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enetr the salary:");
        double salary = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the bonus :");
        double bonus = double.Parse(Console.ReadLine());

        // Calculate total income
        double totalIncome = salary + bonus;
        Console.WriteLine("The salary is INR : " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + totalIncome);
    }
}