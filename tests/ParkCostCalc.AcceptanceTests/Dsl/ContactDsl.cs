using System;
using ParkCostCalc.Core.Specs.Models;
using ParkCostCalc.Core.Specs.Drivers.CostCalculator;

namespace ParkCostCalc.Core.Specs.Dsl
{
    public class ContactDsl
    {
        private readonly ICostCalculatorDriver _driver;

        public ContactDsl(ICostCalculatorDriver driver)
        {
           _driver = driver;
        }

       public decimal CalculateCost(ParkTypeEnum parkingLot, string duration)
        {
            return _driver.CalculateCost(parkingLot, duration);
        }


    }
}
