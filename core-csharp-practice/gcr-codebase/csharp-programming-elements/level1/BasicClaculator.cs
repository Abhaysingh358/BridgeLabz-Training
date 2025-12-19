using System;
class BasicClaculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        float number1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        float number2 = float.Parse(Console.ReadLine());
        // Performing basic arithmetic operations

        float sum = number1 + number2;
        float subtraction = number1 - number2;
        float multiplication = number1 * number2;
        float division = number1 / number2;

        Console.WriteLine(" The addition, subtraction, multiplication and division value of 2 numbers " +
         number1 + " and " + number2 + " is : " + sum + ", " + subtraction + ", " + multiplication + ", and " + division);

    }
}