using ParkCostCalc.AcceptanceTests.Drivers.CostCalculator;
using ParkCostCalc.AcceptanceTests.Models;

namespace ParkCostCalc.AcceptanceTests.Dsl
{
    public class CostCalculatorDsl
    {
        private readonly ICostCalculatorDriver _driver;

        protected CostCalculatorDsl(ICostCalculatorDriver driver)
        {
            _driver = driver;
        }

        public decimal CalculateCost(ParkTypeEnum parkingLot, string duration)
        {
            return _driver.CalculateCost(parkingLot, duration);
        }
    }
}