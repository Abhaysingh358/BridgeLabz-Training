using System;
class Factorial
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        int num = int.Parse(Console.ReadLine());
        
        // if user enter 0
        if(num == 0)
        {
            Console.WriteLine("The factorial of 0 is 1");
            return;
        }
        // if user enter negative number
        else if(num < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers");
            return;
        }
        // if user enter positive number
        else{
        int factorial = 1;
        int i = num;
        while(i >= 1)
        {
            factorial *= i;
            i--;
        }
        Console.WriteLine("The factorial of " + num + " is " + factorial);
    }
    }
}