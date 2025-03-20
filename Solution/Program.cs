using System;

class StockTrader
{
    public int MaximizeProfit(int[] prices)
    {
        int profit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > prices[i - 1])
            {
                profit += prices[i] - prices[i - 1];
            }
        }
        return profit;
    }

    static void Main(string[] args)
    {
        StockTrader trader = new StockTrader();

        int[] stock_prices1 = { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine(trader.MaximizeProfit(stock_prices1)); // Salida esperada: 7

        int[] stock_prices2 = { 1, 2, 3, 4, 5 };
        Console.WriteLine(trader.MaximizeProfit(stock_prices2)); // Salida esperada: 4

        int[] stock_prices3 = { 7, 6, 4, 3, 1 };
        Console.WriteLine(trader.MaximizeProfit(stock_prices3)); // Salida esperada: 0

        int[] stock_prices4 = { 1, 10, 2, 3 };
        Console.WriteLine(trader.MaximizeProfit(stock_prices4)); // Salida esperada: 10
    }
}
