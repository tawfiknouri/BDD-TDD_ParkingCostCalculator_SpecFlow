using ParkCostCalc.Core.Helpers;
using System;

namespace ParkCostCalc.Core.Services.CostCalculators
{
    public class Valet : CalculatorBase, ICostCalc
    {
        private const decimal COST_IN_5_HOURS = 12;
        private const decimal COST_PER_DAY = 18;

        public decimal CalculateCost(double totalMinutes)
        {
            TimeSpan duration = TimeSpan.FromMinutes(totalMinutes);
            decimal totalCost = 0;
            if (totalMinutes <= 0) totalCost = 0;
            else
             if (totalMinutes <= MinuteConvertor.Hours(5))
            {
                totalCost = COST_IN_5_HOURS;
            }
            else
            {
                var days = duration.Days;
                var startedDay = (duration.Hours | duration.Minutes )!= 0 ? 1 : 0;
                var totalDays = days + startedDay;
                totalCost = totalDays* COST_PER_DAY;
            }

            return totalCost;
        }

    }
}
