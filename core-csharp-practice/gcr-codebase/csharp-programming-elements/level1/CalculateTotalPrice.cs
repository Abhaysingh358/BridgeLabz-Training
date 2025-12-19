using System;
class CalculateTotalPrice
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the price of the item:");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the quantity of the item:");
        int quantity = int.Parse(Console.ReadLine());
        // Calculate total price
        // Total Price = Price * Quantity
        double totalPrice = price * quantity;
        Console.WriteLine("The total price for " + quantity + " items at a price of " + price + " each is: " + totalPrice);
    }
}