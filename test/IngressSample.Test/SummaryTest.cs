using IngressSample.Controllers;
using System;
using Xunit;

namespace IngressSample.Test
{
    public class SummaryTest
    {
        [Fact]
        public void TotalTest()
        {
            var summary = new Summary();
            var result = summary.Total(3, 5);

            Assert.Equal(8, result);
        }
    }
}
