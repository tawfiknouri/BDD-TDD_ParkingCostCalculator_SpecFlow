using ParkCostCalc.Core.Interfaces;
using ParkCostCalc.Core.Models;
using ParkCostCalc.Core.Services.CostCalculators;
using System;

namespace ParkCostCalc.Core.Services
{
    public class ParkCostCalcService : IParkCostCalcService
    {

        public CostDetails CalculateCost(ParkTypeEnum parkType, double duration)
        {
            var costCalculator = CalculatorFactory.Get<ICostCalc>(parkType.ToString());
            if (costCalculator == null) return null;
            
            return costCalculator.CalculateCost(duration);

        }
    }
}