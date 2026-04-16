using System;
class RocketLaunchCounter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enetr the coountdown value in seconds");
        int counter = int.Parse(Console.ReadLine());
        while(counter > 0)
        {
            Console.WriteLine("Time left : {0} seconds" , counter);
            counter--;
           
        }
        
        Console.WriteLine("Rocket Launched!");
            
    }
}