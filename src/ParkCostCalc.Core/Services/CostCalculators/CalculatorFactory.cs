using System;
using System.Linq;

namespace ParkCostCalc.Core.Services.CostCalculators
{
    public static class CalculatorFactory
    {
        public static T Get<T>(string name) where T : class
        {
            return typeof(T)
                .Assembly
                .GetTypes()
                .Where(type => type.GetInterfaces().Contains(typeof(T)))
                .Where(type => type.Name.Equals(name))
                .Select(type => Activator.CreateInstance(type) as T)
                .SingleOrDefault();
        }
    }

}
