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
        }
    }
}
