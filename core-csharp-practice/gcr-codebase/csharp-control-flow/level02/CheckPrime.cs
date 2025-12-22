using System;
class CheckPrime
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Number");
        int num = int.Parse(Console.ReadLine());

        bool isPrime = true;

        for(int i =2; i<=num/2;i++){
            if (num % i == 0)
            {
                isPrime= false;
                break;    
            }
        }
        Console.WriteLine(isPrime);

        
    }
}