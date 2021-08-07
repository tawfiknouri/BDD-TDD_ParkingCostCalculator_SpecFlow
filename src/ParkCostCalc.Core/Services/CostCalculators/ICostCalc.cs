using ParkCostCalc.Core.Models;
using System;

namespace ParkCostCalc.Core.Services.CostCalculators
{
     public interface ICostCalc
    {
        public decimal CalculateCost(double totalMinutes);

    }
}