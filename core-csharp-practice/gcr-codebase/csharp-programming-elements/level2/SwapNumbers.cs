using System;
class SwapNumbers
{
    static void Main(string[] args){
        Console.WriteLine("Enetr the first number(integer):");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number(integer):");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Before Swapping: num1  is :" + num1 + ", num2 is : " + num2);

        // swapping logic using temporary variable
        int temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine("The swapped numbers are " + num1 + " and " + num2);
    }
}