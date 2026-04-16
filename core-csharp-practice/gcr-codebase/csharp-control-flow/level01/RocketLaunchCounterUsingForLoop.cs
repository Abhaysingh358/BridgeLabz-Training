using System;
class RocketLaunchCounterUsingForLoop
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enetr the coountdown value in seconds");
        int counter = int.Parse(Console.ReadLine());
        for(int i = counter; i > 0; i--)
        {
            Console.WriteLine(i + " seconds");
        }   
        
        Console.WriteLine("Rocket Launched!");
            
    }
}