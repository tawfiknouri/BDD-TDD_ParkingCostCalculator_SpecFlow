using System;
using System.ComponentModel.DataAnnotations;

namespace ParkCostCalc.Core.Specs.Models
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
