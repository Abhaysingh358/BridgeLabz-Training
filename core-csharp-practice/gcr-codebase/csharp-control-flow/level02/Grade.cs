using System;
class Grade
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Marks of Maths");
        double maths = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Marks of Physics");
        double physics = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Marks of Chemistry");
        double chemistry = double.Parse(Console.ReadLine());

        double average = (maths + physics + chemistry) / 3;
        

    // just normal comparsion as given in the questions to standardize grade
        if (average >= 80 && average <= 100)
        {
            Console.WriteLine("Grade: A");
            Console.WriteLine("Level 4 , above agency-normalised standards");
        }
        else if (average >= 80)
        {
            Console.WriteLine("Grade: B");
            Console.WriteLine("Level 3 , at agency-normalised standards");
        }
        else if (average >= 70)
        {
            Console.WriteLine("Grade: C");
            Console.WriteLine("Level 2 , below ,  but approaching  agency-normalised standards");
        }
        else if (average >= 60)
        {
            Console.WriteLine("Grade: D");
            Console.WriteLine("Level 1 , too below agency-normalised standards");
        }
        else
        {
            Console.WriteLine("Grade: R");
            Console.WriteLine("Remedial Standards");
        }
    }
}