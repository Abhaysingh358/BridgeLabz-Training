using System;
 class FindLargest
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the first number");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the second number");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the third number");
        int num3 = int.Parse(Console.ReadLine());
        bool isLargest1 = false;
        bool isLargest2 = false;
        bool isLargest3 = false;
        if(num1 > num2 && num1 > num3)
        {
            isLargest1 = true;
        }
        else if(num2 > num1 && num2 > num3)
        {
            isLargest2 = true;
        }
        else
        {
            isLargest3 = true;
        }
        Console.WriteLine("Is the first number the largest? " + isLargest1);
        Console.WriteLine("Is the second number the largest? " + isLargest2);
        Console.WriteLine("Is the third number the largest? " + isLargest3);

    }
}