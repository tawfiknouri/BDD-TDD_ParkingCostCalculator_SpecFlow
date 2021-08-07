using ParkCostCalc.Core.Models;
using ParkCostCalc.Core.Services.CostCalculators;
using System;

namespace ParkCostCalc.Core.Services
{
    public class ParkCostCalcService : IParkCostCalcService
    {
        /// <summary>
        /// Calculate the parking cost
        /// </summary>
        /// <param name="parkRequest">Request represent the parking lot (type) and parking duration</param>
        /// <returns></returns>
        public CostDetails CalculateCost(ParkRequest parkRequest)
        {
            var costCalculator = CalculatorFactory.Get<ICostCalc>(parkRequest.ParkType.ToString());
            if (costCalculator == null) return null;

            var totalMinutes = (parkRequest.ExitDate - parkRequest.EntryDate).Value.TotalMinutes;
            var totalCost = costCalculator.CalculateCost(totalMinutes);

            TimeSpan duration = TimeSpan.FromMinutes(totalMinutes);

            return new CostDetails
            {
                Cost = decimal.Round(totalCost, 2),
                Days = duration.Days,
                Hours = duration.Hours,
                Minutes = duration.Minutes
            };
        }
    }
}