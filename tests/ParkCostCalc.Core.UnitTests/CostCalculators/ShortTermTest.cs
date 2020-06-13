using NUnit.Framework;
using ParkCostCalc.Core.Services.CostCalculators;
using System;

namespace ParkCostCalc.Core.UnitTests.CostCalculators
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

        [Test]
        public void Should_Charge_0_Euros_When_ShortTerm_Parking_Time_Is_Negative()
        {
            var totalMinutes = -1;

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(0, cost);
        }

        [Test]
        public void Should_Charge_0_Euros_When_ShortTerm_Parking_Time_Is_0_Minute()
        {
            long totalMinutes = 0;

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(0, cost);
        }
        [Test]
        public void Should_Charge_2_Euros_When_ShortTerm_Parking_Time_Is_30_Minutes()
        {
            long totalMinutes = 30;

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(2, cost);
        }

        [Test]
        public void Should_Charge_2_Euros_When_ShortTerm_Parking_Time_Is_1_Hour()
        {
            long totalMinutes = (1 * 60);

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(2, cost);
        }

        [Test]
        public void Should_Charge_7_Euros_When_ShortTerm_Parking_Time_Is_3_Hours_30_Minutes()
        {
            long totalMinutes = (3 * 60) + 30;

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(7, cost);
        }
        [Test]
        public void Should_Charge_24_Euros_When_ShortTerm_Parking_Time_Is_12_Hours_30_Minutes()
        {
            long totalMinutes = (12 * 60) + 30;

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(24, cost);
        }
        [Test]
        public void Should_Charge_25_Euros_When_ShortTerm_Parking_Time_Is_1_Day_30_Minutes()
        {
            long totalMinutes = (1 * 24 * 60) + 30;

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(25, cost);
        }
        [Test]
        public void Should_Charge_26_Euros_When_ShortTerm_Parking_Time_Is_1_Day_1_Hour()
        {
            long totalMinutes = (1 * 24 * 60) + 60;

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(26, cost);
        }


    }
}
