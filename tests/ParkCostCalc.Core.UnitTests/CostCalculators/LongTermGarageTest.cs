using NUnit.Framework;
using ParkCostCalc.Core.Services.CostCalculators;
using System;

namespace ParkCostCalc.Core.UnitTests.CostCalculators
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

        [Test]
        public void Should_Charge_0_Euros_When_LongTermGarage_Parking_Time_Is_Negative()
        {
            var totalMinutes = -1;

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(0, cost);
        }

        [Test]
        public void Should_Charge_0_Euros_When_LongTermGarage_Parking_Time_Is_0_Minute()
        {
            var totalMinutes = 0;

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(0, cost);
        }

        [Test]
        public void Should_Charge_2_Euros_When_LongTermGarage_Parking_Time_Is_30_Minutes()
        {
            var totalMinutes = 30;

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(2, cost);
        }
        [Test]
        public void Should_Charge_2_Euros_When_LongTermGarage_Parking_Time_Is_1_Hour()
        {
            var totalMinutes = (1 * 60);

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(2, cost);
        }
        [Test]
        public void Should_Charge_6_Euros_When_LongTermGarage_Parking_Time_Is_3_Hours()
        {
            var totalMinutes = (3 * 60);

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(6, cost);
        }

        [Test]
        public void Should_Charge_12_Euros_When_LongTermGarage_Parking_Time_Is_6_Hours()
        {
            var totalMinutes = (6 * 60);

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(12, cost);
        }

        [Test]
        public void Should_Charge_12_Euros_When_LongTermGarage_Parking_Time_Is_7_Hours()
        {
            var totalMinutes = (7 * 60);

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(12, cost);
        }

        [Test]
        public void Should_Charge_12_Euros_When_LongTermGarage_Parking_Time_Is_24_Hours()
        {
            var totalMinutes = (24 * 60);

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(12, cost);
        }


        [Test]
        public void Should_Charge_14_Euros_When_LongTermGarage_Parking_Time_Is_1_Day_1_Hour()
        {
            var totalMinutes = (1 * 24 * 60) + (1 * 60);

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(14, cost);
        }

        [Test]
        public void Should_Charge_18_Euros_When_LongTermGarage_Parking_Time_Is_1_Day_3_Hours()
        {
            var totalMinutes = (1 * 24 * 60) + (3 * 60);

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(18, cost);
        }


        [Test]
        public void Should_Charge_24_Euros_When_LongTermGarage_Parking_Time_Is_1_Day_7_Hours()
        {
            var totalMinutes = (1 * 24 * 60) + (7 * 60);

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(24, cost);
        }


        [Test]
        public void Should_Charge_72_Euros_When_LongTermGarage_Parking_Time_Is_6_Days()
        {
            var totalMinutes = (6 * 24 * 60);

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(72, cost);
        }

        [Test]
        public void Should_Charge_72_Euros_When_LongTermGarage_Parking_Time_Is_6_Days_1_Hour()
        {
            var totalMinutes = (6 * 24 * 60) + (1 * 60);

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(72, cost);
        }

        [Test]
        public void Should_Charge_72_Euros_When_LongTermGarage_Parking_Time_Is_7_Days()
        {
            var totalMinutes = (7 * 24 * 60);

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(72, cost);
        }

        [Test]
        public void Should_Charge_96_Euros_When_LongTermGarage_Parking_Time_Is_1_Week_2_Days()
        {
            var totalMinutes = (1 * 7 * 24 * 60) + (2 * 24 * 60);

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(96, cost);
        }


        [Test]
        public void Should_Charge_216_Euros_When_LongTermGarage_Parking_Time_Is_3_Weeks()
        {
            var totalMinutes = (3 * 7 * 24 * 60);

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(216, cost);
        }

    }
}