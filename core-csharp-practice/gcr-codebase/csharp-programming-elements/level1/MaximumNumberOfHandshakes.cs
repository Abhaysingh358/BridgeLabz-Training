using System;
class MaximumNumberOfHandshakes
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of people in the room:");
        int numberOfStudents = int.Parse(Console.ReadLine());
    // using the formula to calculate maximum handshakes(n)
    // Maximum Handshakes = n(n-1)/2
        int maxHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
        Console.WriteLine("The maximum number of handshakes : " + maxHandshakes);
    }
}