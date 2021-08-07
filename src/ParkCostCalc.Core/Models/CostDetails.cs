using System;

namespace ParkCostCalc.Core.Models
{
    public class CostDetails
    {
        public decimal Cost { get; set; }
        public String Currency { get; set; } = "€";
        public double Days { get; set; }
        public double Hours { get; set; }
        public double Minutes { get; set; }
  
    }
}