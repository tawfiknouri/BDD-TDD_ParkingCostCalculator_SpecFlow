namespace ParkCostCalc.Core.Services.CostCalculators
{
    public interface ICostCalc
    {
        public decimal CalculateCost(double totalMinutes);
    }
}