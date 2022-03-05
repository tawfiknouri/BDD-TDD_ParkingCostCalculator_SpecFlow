using NUnit.Framework;
using ParkCostCalc.Core.Services.CostCalculators;

namespace ParkCostCalc.UnitTests.CostCalculators
{
    [TestFixture]
    public class ValetTest
    {
        private ICostCalc _costCalculator;

        [SetUp]
        public void Setup()
        {
            _costCalculator = new Valet();
        }

        [TestCase(-1, 0, TestName = "Cost for negative parking time")]
        [TestCase(0, 0, TestName = "Cost for 0 Minute")]
        [TestCase(30, 12, TestName = "Cost for 30 Minutes")]
        [TestCase((3 * 60), 12, TestName = "Cost for 3 Hours")]
        [TestCase((5 * 60), 12, TestName = "Cost for 5 Hours")]
        [TestCase((5 * 60) + 1, 18, TestName = "Cost for 5 Hours 1 Minute")]
        [TestCase((12 * 60), 18, TestName = "Cost for 12 Hours")]
        [TestCase((12 * 60), 18, TestName = "Cost for 24 Hours")]
        [TestCase((1 * 24 * 60) + 1, 36, TestName = "Cost for 1 Day 1 Minute")]
        [TestCase((3 * 24 * 60), 54, TestName = "Cost for 3 Days")]
        [TestCase((1 * 7 * 24 * 60), 126, TestName = "Cost for 1 Week")]
        public void Should_Charge_Expected_Cost(int totalMinutes, decimal expectedCost)
        {
            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(expectedCost, cost);
        }
    }
}