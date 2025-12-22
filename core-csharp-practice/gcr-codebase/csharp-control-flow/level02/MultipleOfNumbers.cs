using System;
class MultipleOfNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        int num = int.Parse(Console.ReadLine());
        // check multiple from 100 to 1
        for(int i = 100 ; i>0; i--)
        {
            // check divisiblity so that we know that is a multiple
            if(num % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}