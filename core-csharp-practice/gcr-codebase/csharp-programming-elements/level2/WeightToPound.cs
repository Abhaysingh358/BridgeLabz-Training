using System;
class WeightToPound
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the weight in kilograms:");
        double kilograms = double.Parse(Console.ReadLine());

        // 1 pound = 2.2 kg 

        double pounds = kilograms * 2.2; //conversion factor
        Console.WriteLine("The weight of the person in pounds : " + pounds + " lbs" + " in kgs + " + kilograms);
    }
}