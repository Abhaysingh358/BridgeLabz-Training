using System;
class FindPower
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enetr the Number");
        int number  = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the power");
        int power = int.Parse(Console.ReadLine());

        int result = 1;

        for(int i =1; i<=power ; i++)
        {
            result*=number;
        }

        Console.WriteLine("result is : " + result);
    }
}