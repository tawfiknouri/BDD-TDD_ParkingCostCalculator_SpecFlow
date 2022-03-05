using System;

namespace ParkCostCalc.Core.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.Now;
    }
}