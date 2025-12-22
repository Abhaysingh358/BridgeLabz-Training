using System;
class VotingEligibility
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the age in numbers");
        int age = int.Parse(Console.ReadLine());
        if(age >= 18 && age<= 110)
        {
            Console.WriteLine("The person can vote");
        }
        else if(
        {
            Console.WriteLine("The person can not vote");
        }
    }
}