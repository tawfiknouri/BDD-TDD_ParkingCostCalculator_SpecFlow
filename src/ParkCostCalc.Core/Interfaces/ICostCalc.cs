using ParkCostCalc.Core.Models;
using System;

namespace ParkCostCalc.Core.Interfaces
{
     public interface ICostCalc
    {
        public CostDetails CalculateCost(double totalMinutes);

    }
}