using System;

namespace AccountingMetrics
{
    class Program
    {
        static void Main(string[] args)
        {
            var metrics = new Metrics(new AccountRepository("../../../../../data.json"));
            var revenue = metrics.CalRevenue();
            Console.WriteLine($"Revenue: {revenue}");            
            
            var expenses = metrics.CalExpenses();
            Console.WriteLine($"expenses: {expenses}");

            var grossMargin = metrics.CalGrossProfitMargin(revenue);
            Console.WriteLine($"Gross Profit Margin: {grossMargin}");

            var netMargin = metrics.CalNetProfitMargin(revenue, expenses);
            Console.WriteLine($"Gross Profit Margin: {netMargin}");
        }
    }
}
