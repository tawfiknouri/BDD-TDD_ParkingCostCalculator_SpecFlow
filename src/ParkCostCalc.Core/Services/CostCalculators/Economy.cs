

using ParkCostCalc.Core.Models;
using System;

namespace ParkCostCalc.Core.Services.CostCalculators
{
    public class Economy : CalculatorBase, ICostCalc
    {
        private const decimal MAX_COST_PER_WEEK = 54;
        private const decimal MAX_COST_PER_DAY = 9;
        private const decimal MAX_COST_PER_HOUR = 2;

        public decimal CalculateCost(double totalMinutes)
        {
            return CalculateCost(totalMinutes, MAX_COST_PER_WEEK, MAX_COST_PER_DAY, MAX_COST_PER_HOUR);
        }
    }
}
