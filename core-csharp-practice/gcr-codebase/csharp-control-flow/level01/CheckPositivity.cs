using System;
class CheckPositivity
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enetr A Number");
        int num = int.Parse(Console.ReadLine());
        if(num > 0)
        {
            Console.WriteLine("positive");
        }
        else if(num == 0)
        {
            Console.WriteLine("zero");
        }
        else
        {
            Console.WriteLine("Negative");
        }
    }
}