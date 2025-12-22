using System;
class FirstSmallest
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the first the number");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the second number");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the third number");
        int num3 = int.Parse(Console.ReadLine());
        if(num1 <num2 && num1 < num3)
        {
            Console.WriteLine("First number is the smallest:" + num1);
        }
        else
        {
            Console.WriteLine("First number is not smallest");
        }
        }
    }
