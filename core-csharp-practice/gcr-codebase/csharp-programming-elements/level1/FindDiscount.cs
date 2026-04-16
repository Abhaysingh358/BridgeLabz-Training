using System;
public class FindDiscount
{
    static void Main(string[] args)
    {
        double fee = 125000;
        double discountPercentage = 10;
        double discount  = (discountPercentage / 100) * fee;
        double finalAmount = fee - discount;
        Console.WriteLine("The Fee is INR " + fee + " and the Discount is INR " + discount + " and the Final Amount is INR " + finalAmount);
    }
}