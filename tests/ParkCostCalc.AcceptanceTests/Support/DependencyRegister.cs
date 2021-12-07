using BoDi;

using ParkCostCalc.Core.Specs.Drivers.CostCalculator;
namespace ParkCostCalc.AcceptanceTests.Support
{
    public class DependencyRegister
    {
        public static void RegisterDependencies(IObjectContainer objectContainer)
        {
            objectContainer.RegisterTypeAs<CostCalculatorApiDriver, ICostCalculatorDriver>();

        }
    }
}