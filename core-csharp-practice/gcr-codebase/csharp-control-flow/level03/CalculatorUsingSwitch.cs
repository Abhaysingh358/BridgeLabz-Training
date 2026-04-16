using System;

class CalculatorUsingSwitch
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter an operator (+, -, *, /):");
        string operatr = Console.ReadLine();

        double result = 0;
        bool isValid = true;

// using switch case to use it like a calculator where user gives input
        switch (operatr)
        {
            case "+":
                result = num1 + num2;
                break;

            case "-":
                result = num1 - num2;
                break;

            case "*":
                result = num1 * num2;
                break;

            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero!");
                    isValid = false;
                }
                else
                {
                    result = num1 / num2;
                }
                break;

            default:
                Console.WriteLine("Invalid Operator");
                isValid = false;
                break;
        }

        if (isValid)
        {
            Console.WriteLine("Result: " + result);
        }
    }
}
