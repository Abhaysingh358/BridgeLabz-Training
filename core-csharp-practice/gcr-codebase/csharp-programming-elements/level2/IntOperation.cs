using System;
class IntOperation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of a :");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of b :");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Value of c :");
        int c = int.Parse(Console.ReadLine());

        //  Performing various integer operations
        // 1.a + b * c
        int operation1 = a + b * c;

        // 2.a * b + c
        int operation2 = a * b + c;


        // 3. c + a / b
        int operation3 = c + a / b;

        // 4. a % b + c
        int operation4 = a % b + c;
        Console.WriteLine("The results of Int Operations are respectively : {0}, {1}, {2}, {3}", operation1, operation2, operation4, operation3);
    }
}