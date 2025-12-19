using System;
class UsingOperators
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first Number : ");
        // taking input from user
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second Number : ");
        double num2 = double.Parse(Console.ReadLine());

        double quotient = num1 / num2; // division operator
        double remainder = num1 % num2; // modulus operator
        Console.WriteLine("The Quotient of " + num1 + " and " + num2 + " is : " + quotient);
        Console.WriteLine("The Remainder of " + num1 + " and " + num2 + " is : " + remainder);

    }
}