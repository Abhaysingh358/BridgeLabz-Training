    // Create a program to find the multiplication table of a number entered by the user from 6 to 9.
    // Hint => 
    // Take integer input and store it in the variable number
    // Using a for loop, find the multiplication table of number from 6 to 9 and print it in the format number * i = ___ 

using System;
class MultiplicationTable
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number to find the multiplication table of number from 6 to 9");
        int num = int.Parse(Console.ReadLine());

        for(int i= 6; i <= 9; i++)
        {
            // the below line of code will print multiplication table
            Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
        }
    }
}