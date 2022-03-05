using BoDi;
using ParkCostCalc.AcceptanceTests.Drivers.CostCalculator;

namespace ParkCostCalc.AcceptanceTests.Support
{
    public static class DependencyRegister
    {
        public static void RegisterDependencies(IObjectContainer objectContainer)
        {
            objectContainer.RegisterTypeAs<CostCalculatorApiDriver, ICostCalculatorDriver>();
        }
    }
}