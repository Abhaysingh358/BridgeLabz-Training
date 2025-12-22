using System;
class FindBMI
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enetr the weight in kgs");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Enetr the height in cms");
        double heightInCms = double.Parse(Console.ReadLine());

        double heightInMeters = heightInCms / 100;

        //  using formula to calculate bmi

        double BMI = weight / (heightInMeters * heightInMeters);

        // using conditions to categarize

        if(BMI <= 18.4)
        {
            Console.WriteLine("UnderWeight");
        }
        else if(BMI <= 24.9 &&  BMI >= 18.5)
        {
            Console.WriteLine("Normal");
        }
        else if(BMI <= 39.9 && BMI >= 25.0)
        {
            Console.WriteLine("OverWeight");
        }
        else if(BMI >= 40.0)
        {
            Console.WriteLine("Obese");
        }
        else
        {
            Console.WriteLine("Inavalid Range");
        }

    }
}