using ParkCostCalc.Core.Models;
namespace ParkCostCalc.Core.Interfaces
{
     public interface IParkCostCalcService
    {
        public CostDetails CalculateCost(ParkTypeEnum parkType, double duration);

    }
}