using ParkCostCalc.AcceptanceTests.Models;

namespace ParkCostCalc.AcceptanceTests.Drivers.CostCalculator
{
    public interface ICostCalculatorDriver
    {
        public decimal CalculateCost(ParkTypeEnum parkingLot, string duration);
    }
}