using NUnit.Framework;
using ParkCostCalc.Core.Models;
using ParkCostCalc.Core.Specs.Drivers;
using ParkingCostCalculator.Specs.Helpers;
using System;

using TechTalk.SpecFlow;

namespace ParkCostCalc.Core.Specs.StepDefinitions
{
    [Binding]
    public class CostCalculatorSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly CostCalculatorDriver _costCalcdriver;

        public CostCalculatorSteps(ScenarioContext scenarioContext, CostCalculatorDriver costCalcdriver)
        {
            _scenarioContext = scenarioContext;
            _costCalcdriver = costCalcdriver;
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

            var costDetails  = _costCalcdriver.CalculateCost(parkType, duration);
            _scenarioContext.Add("CostDetails", costDetails);
        }

        [Then(@"the parking cost should be (.*)")]
        public void ThenTheParkingCostShouldBe(string expectedCost)
        {
            _scenarioContext.TryGetValue("CostDetails", out CostDetails costDetails);
            Assert.AreEqual(Parser.ParseCost(expectedCost), costDetails.Cost);
        }

    }


}