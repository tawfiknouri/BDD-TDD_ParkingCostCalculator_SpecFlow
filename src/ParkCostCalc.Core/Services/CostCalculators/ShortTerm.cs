using ParkCostCalc.Core.Models;
using System;

namespace ParkCostCalc.Core.Services.CostCalculators
{
    public class ShortTerm : CalculatorBase, ICostCalc
    {
        private const decimal COST_FIRST_HOUR = 2;
        private const decimal MAX_COST_PER_DAY = 24;
        private const decimal MAX_COST_PER_HALF_HOUR = 1;
        private const int ONE_MINUTE = 1;
        private const int HALF_HOUR = ONE_MINUTE * 30;
        private const int ONE_HOUR = ONE_MINUTE * 60;

        public decimal CalculateCost(double totalMinutes)
        {
            decimal totalCost = 0;
            TimeSpan duration = TimeSpan.FromMinutes(totalMinutes);
            if (totalMinutes <= 0) totalCost = 0;
            else if (totalMinutes <= ONE_HOUR) totalCost = COST_FIRST_HOUR;
            else
            {
                var daysCost = duration.Days * MAX_COST_PER_DAY;
               
                var totalHalfHours = (duration.Hours * 2) + (duration.Minutes / HALF_HOUR) + (duration.Minutes % HALF_HOUR);
                var halfHoursCost = Math.Min(totalHalfHours * MAX_COST_PER_HALF_HOUR, MAX_COST_PER_DAY);
                
                totalCost = daysCost + halfHoursCost;
            }

            return totalCost;
        }

       
    }
}