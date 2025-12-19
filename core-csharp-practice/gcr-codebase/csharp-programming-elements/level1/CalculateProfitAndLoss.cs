using System;
public class CalculateProfitAndLoss
{
    static void Main(string[] args)
    {
        double costPrice = 129;
        double sellingPrice = 191;
        // Calculating Profit and Profit Percentage
        double profit = sellingPrice - costPrice;
        // Profit Percentage
        double profitPercentage = (profit / costPrice) * 100;
        // Displaying the result
        Console.WriteLine("The Cost Price is INR " + costPrice + " and Selling Price is INR " + sellingPrice +
                          "\nThe Profit is INR " + profit + " and the Profit Percentage is  " + profitPercentage);
    }
}