
using ParkCostCalc.Core.Specs.Models;

namespace ParkCostCalc.Core.Specs.Drivers.CostCalculator
{
     public interface ICostCalculatorDriver
    {
        public decimal CalculateCost(ParkTypeEnum parkingLot, string duration);

    }
}