using System;
public class AverageOfMarks
{
    static void Main(string[] args)
    {
        double mathsMarks = 94;
        double physicsMarks = 96;
        double chemistryMarks = 90;
        double totalMarks = mathsMarks + physicsMarks + chemistryMarks;
        double averageMarks = totalMarks / 3;
        Console.WriteLine("Sam’s average mark in PCM is" + averageMarks);    

    }
}