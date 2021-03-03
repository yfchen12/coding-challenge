using System;
using Xunit;

namespace AccountingMetrics.Tests
{
    public class MetricsTest
    {
        private readonly Metrics _metrics;
        public MetricsTest()
        {
            _metrics = new Metrics(new FakeAccountRepository());
        }
        [Fact]
        public void testCalRevenue()
        {
            float actual = _metrics.CalRevenue();
            Assert.Equal(3, actual);
        }

        [Fact]
        public void testCalExpenses()
        {
            float actual = _metrics.CalExpenses();
            Assert.Equal(7, actual);
        }

    }
}
