using System;
using BoDi;
using Microsoft.Extensions.Logging;

using ParkCostCalc.Core.Specs.Drivers.CostCalculator;
namespace ParkCostCalc.AcceptanceTests.Support
{
    public class DependencyRegister
    {
        public static void RegisterDependencies(IObjectContainer objectContainer)
        {
            objectContainer.RegisterInstanceAs(new LoggerFactory(), typeof(ILoggerFactory));
            objectContainer.RegisterTypeAs<CostCalculatorApiDriver, ICostCalculatorDriver>();

        }
    }
}