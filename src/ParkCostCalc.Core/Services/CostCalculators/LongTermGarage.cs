namespace ParkCostCalc.Core.Services.CostCalculators
{
    public class LongTermGarage : CalculatorBase, ICostCalc
    {
        private const int MAX_COST_PER_WEEK = 72;
        private const int MAX_COST_PER_DAY = 12;
        private const int MAX_COST_PER_HOUR = 2;

        public decimal CalculateCost(double totalMinutes)
        {
            return CalculateCost(totalMinutes, MAX_COST_PER_WEEK, MAX_COST_PER_DAY, MAX_COST_PER_HOUR);
        }
    }
}