using NUnit.Framework;
using ParkCostCalc.Core.Services.CostCalculators;

namespace ParkCostCalc.Core.UnitTests.CostCalculators
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

        [Test]
        public void Should_Charge_0_Euros_When_Valet_Parking_Time_Is_Negative()
        {
            var totalMinutes = -1;

            var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(0, cost);
        }

        [Test]
        public void Should_Charge_0_Euros_When_Valet_Parking_Time_Is_0_Minute()
        {
            var totalMinutes = 0;

             var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(0, cost);
        }

        [Test]
        public void Should_Charge_12_Euros_When_Valet_Parking_Time_Is_30_Minutes()
        {
            var totalMinutes = 30;

             var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(12, cost);
        }



        [Test]
        public void Should_Charge_12_Euros_When_Valet_Parking_Time_Is_3_Hours()
        {
            var totalMinutes = (3 * 60);

             var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(12, cost);
        }


        [Test]
        public void Should_Charge_12_Euros_When_Valet_Parking_Time_Is_5_Hours()
        {
            var totalMinutes = (5 * 60);

             var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(12, cost);
        }


        [Test]
        public void Should_Charge_18_Euros_When_Valet_Parking_Time_Is_5_Hours_1_Minute()
        {
            var totalMinutes = (5 * 60) + 1;

             var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(18, cost);
        }

        [Test]
        public void Should_Charge_18_Euros_When_Valet_Parking_Time_Is_12_Hours()
        {
            var totalMinutes = (12 * 60);

             var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(18, cost);
        }

        [Test]
        public void Should_Charge_18_Euros_When_Valet_Parking_Time_Is_24_Hours()
        {
            var totalMinutes = (24 * 60);

             var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(18, cost);
        }


        [Test]
        public void Should_Charge_36_Euros_When_Valet_Parking_Time_Is_1_Day_1_Minute()
        {
            var totalMinutes = (1 * 24 * 60) + 1;

             var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(36, cost);
        }


        [Test]
        public void Should_Charge_54_Euros_When_Valet_Parking_Time_Is_3_Days()
        {
            var totalMinutes = (3 * 24 * 60);

             var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(54, cost);
        }


        [Test]
        public void Should_Charge_126_Euros_When_Valet_Parking_Time_Is_1_Week()
        {
            var totalMinutes = (1 * 7 * 24 * 60);

             var cost = _costCalculator.CalculateCost(totalMinutes);

            Assert.AreEqual(126, cost);
        }

    }
}
