using NUnit.Framework;
using ParkCostCalc.Core.Interfaces;
using ParkCostCalc.Core.Services.CostCalculators;
using System;

namespace ParkCostCalc.Core.UnitTests.CostCalculators
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

        [Test]
        public void Should_Charge_0_Euros_When_Economy_Parking_Time_Is_Negative()
        {
            var totalMinutes = -1;

            var costDetails = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(0, costDetails.Cost);
        }

        [Test]
        public void Should_Charge_0_Euros_When_Economy_Parking_Time_Is_0_Minute()
        {
            var totalMinutes = 0;

            var costDetails = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(0, costDetails.Cost);
        }

        [Test]
        public void Should_Charge_2_Euros_When_Economy_Parking_Time_Is_30_Minutes()
        {
            var totalMinutes = 30;

            var costDetails = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(2, costDetails.Cost);
        }

        [Test]
        public void Should_Charge_2_Euros_When_Economy_Parking_Time_Is_1_Hour()
        {
            var totalMinutes = (1 * 60);

            var costDetails = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(2, costDetails.Cost);
        }

        [Test]
        public void Should_Charge_8_Euros_When_Economy_Parking_Time_Is_4_Hours()
        {
            var totalMinutes = (4 * 60);

            var costDetails = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(8, costDetails.Cost);
        }

        [Test]
        public void Should_Charge_9_Euros_When_Economy_Parking_Time_Is_5_Hours()
        {
            var totalMinutes = (5 * 60);
    
            var costDetails = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(9, costDetails.Cost);
        }

        [Test]
        public void Should_Charge_9_Euros_When_Economy_Parking_Time_Is_6_Hours()
        {
            var totalMinutes = (6 * 60);
     
            var costDetails = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(9, costDetails.Cost);
        }

        [Test]
        public void Should_Charge_9_Euros_When_Economy_Parking_Time_Is_24_Hours()
        {
            var totalMinutes = (24 * 60);

            var costDetails = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(9, costDetails.Cost);
        }

        [Test]
        public void Should_Charge_11_Euros_When_Economy_Parking_Time_Is_1_Day_1_Hour()
        {
            var totalMinutes = (1 * 24 * 60) + (1 * 60);

            var costDetails = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(11, costDetails.Cost);
        }

        [Test]
        public void Should_Charge_15_Euros_When_Economy_Parking_Time_Is_1_Day_3_Hours()
        {
            var totalMinutes = (1 * 24 * 60) + (3 * 60);

            var costDetails = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(15, costDetails.Cost);
        }

        [Test]
        public void Should_Charge_18_Euros_When_Economy_Parking_Time_Is_1_Day_5_Hours()
        {
            var totalMinutes = (1 * 24 * 60) + (5 * 60);

            var costDetails = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(18, costDetails.Cost);
        }

        [Test]
        public void Should_Charge_54_Euros_When_Economy_Parking_Time_Is_6_Days()
        {
            var totalMinutes = (6 * 24 * 60);

            var costDetails = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(54, costDetails.Cost);
        }

        [Test]
        public void Should_Charge_54_Euros_When_Economy_Parking_Time_Is_6_Days_1_Hour()
        {
            var totalMinutes = (6 * 24 * 60) + (1 * 60);

            var costDetails = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(54, costDetails.Cost);
        }

        [Test]
        public void Should_Charge_54_Euros_When_Economy_Parking_Time_Is_7_Days()
        {
            var totalMinutes = (6 * 24 * 60) + (1 * 60);

            var costDetails = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(54, costDetails.Cost);
        }

        [Test]
        public void Should_Charge_72_Euros_When_Economy_Parking_Time_Is_1_Week_2_Days()
        {
            var totalMinutes = (1 * 7 * 24 * 60) + (2 * 24 * 60);

            var costDetails = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(72, costDetails.Cost);
        }


        [Test]
        public void Should_Charge_162_Euros_When_Economy_Parking_Time_Is_3_Weeks()
        {
            var totalMinutes = (3 * 7 * 24 * 60);

            var costDetails = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(162, costDetails.Cost);
        }

    }
}
