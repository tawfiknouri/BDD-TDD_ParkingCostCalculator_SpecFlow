using NUnit.Framework;
using ParkCostCalc.Core.Services.CostCalculators;

namespace ParkCostCalc.UnitTests.CostCalculators
{
    [TestFixture]
    public class LongTermGarageTest
    {
        private ICostCalc _costCalculator;

        [SetUp]
        public void Setup()
        {
            _costCalculator = new LongTermGarage();
        }

        [TestCase(-1, 0, TestName = "Cost for negative parking time")]
        [TestCase(0, 0, TestName = "Cost for 0 Minute")]
        [TestCase(30, 2, TestName = "Cost for 30 Minutes")]
        [TestCase((1 * 60), 2, TestName = "Cost for 1 Hour")]
        [TestCase((3 * 60), 6, TestName = "Cost for 3 Hours")]
        [TestCase((6 * 60), 12, TestName = "Cost for 6 Hours")]
        [TestCase((7 * 60), 12, TestName = "Cost for 7 Hours")]
        [TestCase((24 * 60), 12, TestName = "Cost for 24 Hours")]
        [TestCase((1 * 24 * 60) + (1 * 60), 14, TestName = "Cost for 1 Day 1 Hour")]
        [TestCase((1 * 24 * 60) + (3 * 60), 18, TestName = "Cost for 1 Day 3 Hours")]
        [TestCase((1 * 24 * 60) + (7 * 60), 24, TestName = "Cost for 1 Day 7 Hours")]
        [TestCase((6 * 24 * 60), 72, TestName = "Cost for 6 Days")]
        [TestCase((6 * 24 * 60) + (1 * 60), 72, TestName = "Cost for 6 Days 1 Hour")]
        [TestCase((7 * 24 * 60), 72, TestName = "Cost for 7 Days")]
        [TestCase((1 * 7 * 24 * 60) + (2 * 24 * 60), 96, TestName = "Cost for 1 Week 2 Days")]
        [TestCase((3 * 7 * 24 * 60), 216, TestName = "Cost for 3 Weeks")]
        public void Should_Charge_Expected_Cost(int totalMinutes, decimal expectedCost)
        {
            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(expectedCost, cost);
        }
    }
}