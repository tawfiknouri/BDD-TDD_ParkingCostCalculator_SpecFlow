using NUnit.Framework;
using ParkCostCalc.Core.Services.CostCalculators;

namespace ParkCostCalc.UnitTests.CostCalculators
{
    [TestFixture]
    public class EconomyTest
    {
        private ICostCalc _costCalculator;

        [SetUp]
        public void Setup()
        {
            _costCalculator = new Economy();
        }

        [TestCase(-1, 0, TestName = "Cost for negative parking time")]
        [TestCase(0, 0, TestName = "Cost for 0 Minute")]
        [TestCase(30, 2, TestName = "Cost for 30 Minutes")]
        [TestCase((1 * 60), 2, TestName = "Cost for 1 Hour")]
        [TestCase((4 * 60), 8, TestName = "Cost for 4 Hours")]
        [TestCase((5 * 60), 9, TestName = "Cost for 5 Hours")]
        [TestCase((6 * 60), 9, TestName = "Cost for 6 Hours")]
        [TestCase((24 * 60), 9, TestName = "Cost for 24 Hours")]
        [TestCase((1 * 24 * 60) + (1 * 60), 11, TestName = "Cost for 1 Day 1 Hour")]
        [TestCase((1 * 24 * 60) + (3 * 60), 15, TestName = "Cost for 1 Day 3 Hours")]
        [TestCase((1 * 24 * 60) + (5 * 60), 18, TestName = "Cost for 1 Day 5 Hours")]
        [TestCase((6 * 24 * 60), 54, TestName = "Cost for 6 Days")]
        [TestCase((6 * 24 * 60) + (1 * 60), 54, TestName = "Cost for 6 Days 1 Hour")]
        [TestCase((7 * 24 * 60), 54, TestName = "Cost for 7 Days")]
        [TestCase((1 * 7 * 24 * 60) + (2 * 24 * 60), 72, TestName = "Cost for 1 Week 2 Days")]
        [TestCase((3 * 7 * 24 * 60), 162, TestName = "Cost for 3 Weeks")]
        public void Should_Charge_Expected_Cost(int totalMinutes, decimal expectedCost)
        {
            var cost = _costCalculator.CalculateCost(totalMinutes);
            Assert.AreEqual(expectedCost, cost);
        }
    }
}