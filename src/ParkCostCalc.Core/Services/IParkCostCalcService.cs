using ParkCostCalc.Core.Models;
namespace ParkCostCalc.Core.Services
{
     public interface IParkCostCalcService
    {
        public CostDetails CalculateCost(ParkRequest parkRequest);

    }
}