using System;
class DoubleOpt
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enetr the value of a (double):");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enetr the value of b(double):");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Value of c (double):");
        double c = double.Parse(Console.ReadLine());

        //  Performing various double operations
        // 1.a + b * c
        double operation1 = a + b * c;
        // 2.a * b + c
        double operation2 = a * b + c;


        // 3. c + a / b
        double operation3 = c + a / b;
        // 4. a % b + c
        double operation4 = a % b + c;
        Console.WriteLine("The results of Double Operations are respectively : {0}, {1}, {2}, {3}", operation1, operation2, operation4, operation3);
    }
}