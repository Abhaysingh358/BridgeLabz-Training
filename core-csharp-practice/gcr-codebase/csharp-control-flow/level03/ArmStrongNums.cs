using System;
class ArmStrongNums
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Number");
        int num = int.Parse(Console.ReadLine());
        int originalNum = num;

        int sum = 0;

        
        while (num != 0)
        {
            int rem = num % 10;
            int cube = rem*rem*rem;
            sum+=cube;
            num/=10;

        }
        if(originalNum == sum)
        {
            Console.WriteLine("The number is Arm Strong");
        }
        else
        {
            Console.WriteLine("The number is not an  Arm Strong");
        }
      
    }
}