using System;
public class EqualDivision
{
    static void Main(string[] args)
    {
        int pens = 14;
        int students = 10;

        int pensPerStudent = pens / students;
        int remainingPens = pens % students;
        Console.WriteLine("The Pen Per Student is " + pensPerStudent + 
        " and the remaining pen not distributed is " + remainingPens);
    }
}