using System;
class FindDiscountWithInput
{

public class FindDiscount
{
    static void Main(string[] args)

    {
        Console.WriteLine("Enter the fee amount:");
        double fee = double.Parse(Console.ReadLine()); // input
        Console.WriteLine("Enter the discount percentage:");
        double discountPercentage = double.Parse(Console.ReadLine()); // input
        double discount  = (discountPercentage / 100) * fee;
        double finalAmount = fee - discount;
        Console.WriteLine("The Fee is INR " + fee + " and the Discount is INR " + discount + " and the Final discounted fee is INR " + finalAmount);
    }
}
} 
