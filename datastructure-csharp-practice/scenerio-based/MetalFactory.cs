using System;
class PriceChart
{
    private int[] prices;
    public PriceChart(int size)
    {
        prices = new int[size];
    }
    public void SetPrice(int length, int price)
    {
        prices[length] = price;
    }
    public int GetPrice(int length)
    {
        return prices[length];
    }
}
class RodCuttingService
{
    public int GetMaxRevenue(int rodLength, PriceChart chart)
    {
        if (rodLength == 0)
        {
            return 0;
        }
        int maxRevenue = chart.GetPrice(rodLength);
        for (int cut = 1; cut < rodLength; cut++)
        {
            int revenue = chart.GetPrice(cut) + GetMaxRevenue(rodLength - cut, chart);
            if (revenue > maxRevenue)
            {
                maxRevenue = revenue;
            }
        }
        return maxRevenue;
    }
}
class RevenueVisualizer
{
    public void DisplayRevenue(int rodLength, PriceChart chart, RodCuttingService service)
    {
        int optimizedRevenue = service.GetMaxRevenue(rodLength, chart);
        int nonOptimizedRevenue = chart.GetPrice(rodLength);
        Console.WriteLine("Rod Length: " + rodLength);
        Console.WriteLine("Optimized Revenue: " + optimizedRevenue);
        Console.WriteLine("Non-Optimized Revenue: " + nonOptimizedRevenue);
        Console.WriteLine("Profit : " + (optimizedRevenue - nonOptimizedRevenue));
    }
}
class MetalFactory
{
    static void Main()
    {
        PriceChart chart = new PriceChart(10);
        chart.SetPrice(1, 1);
        chart.SetPrice(2, 5);
        chart.SetPrice(3, 8);
        chart.SetPrice(4, 9);
        chart.SetPrice(5, 10);
        chart.SetPrice(6, 17);
        chart.SetPrice(7, 17);
        chart.SetPrice(8, 20);
        RodCuttingService service = new RodCuttingService();
        RevenueVisualizer visualizer = new RevenueVisualizer();

        Console.WriteLine("Scenario  A : For length 8");
        visualizer.DisplayRevenue(8, chart, service);

        Console.WriteLine("\nScenario B : For Custom Length");
        chart.SetPrice(9, 24);
        visualizer.DisplayRevenue(9, chart, service);

        Console.WriteLine("\nScenario C : Non Optimized vs Optimized ");
        visualizer.DisplayRevenue(8, chart, service);
    }
}