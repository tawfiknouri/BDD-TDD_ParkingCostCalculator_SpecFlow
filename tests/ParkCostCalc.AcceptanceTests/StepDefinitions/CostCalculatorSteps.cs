using NUnit.Framework;
using ParkCostCalc.Core.Specs.Drivers;
using ParkCostCalc.Core.Specs.Models;
using ParkCostCalc.Core.Specs.Dsl;
using ParkingCostCalculator.Specs.Helpers;
using System;

using TechTalk.SpecFlow;

namespace ParkCostCalc.Core.Specs.StepDefinitions
{
    [Binding]
    public class CostCalculatorSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly CostCalculatorDsl _costCalcDsl;

        public CostCalculatorSteps(ScenarioContext scenarioContext, CostCalculatorDsl costCalculatorDsl)
        {
            _scenarioContext = scenarioContext;
            _costCalcDsl = costCalculatorDsl;
        }

        [Given(@"parking lot is (.*)")]
        public void GivenParkingLotIs(ParkTypeEnum parkingLot)
        {
            _scenarioContext.Add("parkingLot", parkingLot);
        }

        [Given(@"parking duration is (.*)")]
        public void GivenParkingDuration(string duration)
        {
            _scenarioContext.Add("duration", duration);
        }

        [When(@"the cost estimate is calculated")]
        public void WhenTheCostEstimateIsCalculated()
        {
            _scenarioContext.TryGetValue("duration", out string duration);
            _scenarioContext.TryGetValue("parkingLot", out ParkTypeEnum parkType);

            var cost  = _costCalcDsl.CalculateCost(parkType, duration);
            _scenarioContext.Add("cost", cost);
        }

        [Then(@"the parking cost should be (.*)")]
        public void ThenTheParkingCostShouldBe(string expectedCost)
        {
            _scenarioContext.TryGetValue("cost", out decimal cost);
            Assert.AreEqual(Parser.ParseCost(expectedCost), cost);
        }

    }


}