using System;
class ProfitLoss{
    static void Main(){
        int costPrice=129;
        int sellingPrice=191;
        int profit=sellingPrice-costPrice;
        double profitPercentage=(profit*100)/costPrice;
        Console.WriteLine("The Cost Price is INR 129 and Selling Price is INR 191");
        Console.WriteLine("The Profit is INR " + profit +" and the Profit Percentage is "+ profitPercentage);
    }}