using System;
using System.Globalization;

namespace AccountingMetrics
{
    class Program
    {
        static void Main(string[] args)
        {
            var metrics = new Metrics(new AccountRepository("data.json"));
            var revenue = metrics.CalRevenue();
            Console.WriteLine($"Revenue: {revenue.ToString("c0")}");            
            
            var expenses = metrics.CalExpenses();
            Console.WriteLine($"expenses: {expenses.ToString("c0")}");

            var grossMargin = metrics.CalGrossProfitMargin(revenue);
            Console.WriteLine($"Gross Profit Margin: {(grossMargin).ToString("F0")}%");

            var netMargin = metrics.CalNetProfitMargin(revenue, expenses);
            Console.WriteLine($"Gross Profit Margin: {(netMargin).ToString("F0")}%");

            var workCapRatio = metrics.CalWorkingCapitalRatio();
            Console.WriteLine($"Working Capital Ratio: {(workCapRatio).ToString("F0")}%");

        }
    }
}
