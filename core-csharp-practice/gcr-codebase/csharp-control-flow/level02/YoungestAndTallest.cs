using System;

class YoungestAndTallest
{
    static void Main(string[] args)
    {
        Console.WriteLine("enetr the unique age and height of all threes");
        Console.WriteLine("Enter Amar's age:");
        int AmarAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Amar's height:");
        int AmarHeight = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Akbar's age:");
        int AkbarAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Akbar's height:");
        int AkbarHeight = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Anthony's age:");
        int AnthonyAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Anthony's height:");
        int AnthonyHeight = int.Parse(Console.ReadLine());

        // finding the youngest
        if (AmarAge < AkbarAge && AmarAge < AnthonyAge)
        {
            Console.WriteLine("Amar is the youngest.");

        }
        else if (AkbarAge < AmarAge && AkbarAge < AnthonyAge)
        {
            Console.WriteLine("Akbar is the youngest.");
        }
        else
        {
            Console.WriteLine("Anthony is the youngest.");
        }

        // we are finding  the tallest
        if (AmarHeight > AkbarHeight && AmarHeight > AnthonyHeight)
        {
            Console.WriteLine("Amar is the tallest.");
        }
        else if (AkbarHeight > AmarHeight && AkbarHeight > AnthonyHeight)
        {

            Console.WriteLine("Akbar is the tallest.");
        }
        else
        {
            Console.WriteLine("Anthony is the tallest.");
        }
    }
}
