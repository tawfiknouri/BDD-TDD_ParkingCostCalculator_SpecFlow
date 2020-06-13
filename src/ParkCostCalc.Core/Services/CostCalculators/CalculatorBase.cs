using ParkCostCalc.Core.Models;
using System;

namespace ParkCostCalc.Core.Services.CostCalculators
{
    public class CalculatorBase
    {
        public decimal CalculateCost(double totalMinutes, decimal costsPerWeek, decimal costsPerDay, decimal costsPerHour)
        {
            decimal totalCost = 0;
            TimeSpan duration = TimeSpan.FromMinutes(totalMinutes);
            if (totalMinutes <= 0) totalCost = 0;
            else
            {
                var totalWeeks = duration.Days / 7;
                var totalDays = duration.Days % 7;

                var startedHour = duration.Minutes > 0 ? 1 : 0;

                var totalHours = duration.Hours + startedHour;

                var weeksCost = totalWeeks * costsPerWeek;

                var daysCost = totalDays * costsPerDay;

                // 23h  * 2 = 46 or max per day = 9
                var hoursCost = Math.Min(totalHours * costsPerHour, costsPerDay);

                var daysAndHoursCost = Math.Min(daysCost + hoursCost, costsPerWeek);

                totalCost = weeksCost + daysAndHoursCost;
            }

            return totalCost;
        }

    }
}