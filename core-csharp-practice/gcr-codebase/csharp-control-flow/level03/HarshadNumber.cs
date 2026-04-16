using System;

class HarshadNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());

        if (num == 0)
        {
            Console.WriteLine("0 is NOT a Harshad Number");
            return;
        }

        int temp = num;
        int sum = 0;
        
        // take the remaider and assign it to the digit the add it to the sum 
        // temp divided by 10 so we can repeat the action on the next digit
        while (temp != 0)
        {
            int digit = temp % 10;  
            sum += digit;           
            temp /= 10;            
        }

        if (num % sum == 0)
        {
            Console.WriteLine(num + " is a Harshad Number");
        }
        else
        {
            Console.WriteLine(num + " is NOT a Harshad Number");
        }
    }
}
