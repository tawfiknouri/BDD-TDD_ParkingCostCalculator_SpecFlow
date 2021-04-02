using ParkCostCalc.Core.Interfaces;
using ParkCostCalc.Core.Models;
using ParkCostCalc.Core.Services;
using ParkingCostCalculator.Specs.Helpers;
using System;

namespace ParkCostCalc.Core.Specs.Drivers
{
    public class CostCalculatorDriver
    {

        private readonly IParkCostCalcService _parkCostCalcService;
        public CostCalculatorDriver(ParkCostCalcService parkCostCalcService)
        {
            _parkCostCalcService = parkCostCalcService;
        }

        public CostDetails CalculateCost(ParkTypeEnum parkType, string duration)
        {
            var totalMinutes = Parser.ParseDuration(duration);
            DateTime entryDate = DateTime.Now;
            DateTime exitDate = entryDate.AddMinutes(totalMinutes);

            var costDetails = _parkCostCalcService.CalculateCost(parkType, totalMinutes);
            return costDetails;
        }
    }
}
