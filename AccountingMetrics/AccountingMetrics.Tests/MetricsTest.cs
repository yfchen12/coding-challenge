using System;
using Xunit;

namespace AccountingMetrics.Tests
{
    public class MetricsTest
    {
        [Fact]
        public void testCalRevenue()
        {
            var metrics = new Metrics(new FakeAccountRepository());
            float actual = metrics.CalRevenue();
            Assert.Equal(3, actual);
        }
    }
}
