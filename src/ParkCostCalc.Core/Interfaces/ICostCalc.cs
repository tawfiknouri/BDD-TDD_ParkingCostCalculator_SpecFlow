using ParkCostCalc.Core.Models;
using System;

namespace ParkCostCalc.Core.Interfaces
{
     public interface ICostCalc
    {
        public decimal CalculateCost(double totalMinutes);

    }
}