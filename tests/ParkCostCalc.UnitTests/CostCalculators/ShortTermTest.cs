using NUnit.Framework;
using ParkCostCalc.Core.Services.CostCalculators;

namespace ParkCostCalc.UnitTests.CostCalculators
{
    [TestFixture]
    public class ShortTermTest
    {
        private ICostCalc _costCalculator;

        [SetUp]
        public void Setup()
        {
            _costCalculator = new ShortTerm();
        }

        [TestCase(-1, 0, TestName = "Cost for negative parking time")]
        [TestCase(0, 0, TestName = "Cost for 0 Minute")]
        [TestCase(30, 2, TestName = "Cost for 30 Minutes")]
        [TestCase((1 * 60), 2, TestName = "Cost for 1 Hour")]
        [TestCase((3 * 60) + 30, 7, TestName = "Cost for 3 Hours 30 Minutes")]
        [TestCase((12 * 60) + 30, 24, TestName = "Cost for 12 Hours 30 Minutes")]
        [TestCase((1 * 24 * 60) + 30, 25, TestName = "Cost for 1 Day 30 Minutes")]
        [TestCase((1 * 24 * 60) + (1 * 60), 26, TestName = "Cost for 1 Day 1 Hour")]
        public void Should_Charge_Expected_Cost(int totalMinutes, decimal expectedCost)
        {
            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(expectedCost, cost);
        }
    }
}