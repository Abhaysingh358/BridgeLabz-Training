using System;
class CheckOddEven
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number up to you want to check odd or even:");
        int num = int.Parse(Console.ReadLine());

        int i = 1;
        //  check the number up to user input's number
        while(i<=num)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i + " is Even");
            }
            else
            {
                Console.WriteLine(i + " is Odd");
            }
            i++;
        }
    }
}