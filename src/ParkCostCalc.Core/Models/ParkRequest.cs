using System;

namespace ParkCostCalc.Core.Models
{
    public class ParkRequest
    {
        public ParkTypeEnum? ParkType { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }
    }
}