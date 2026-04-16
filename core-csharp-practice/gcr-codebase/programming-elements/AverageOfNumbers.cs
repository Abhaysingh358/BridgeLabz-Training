using System;

public class AverageOfNumbers
{
    static void Main(string[] args)
    {
      
        double num1 = 3.25;

        
        double num2 = 5.25;

       
        double num3 = 7.25;

        // using the average formula to takout the average
        double average = (num1 + num2 + num3) / 3;

        Console.WriteLine("The average of the three numbers "+ " "+num1+" "+  num2+" " + num3+  " is: " + average);
    }
}
