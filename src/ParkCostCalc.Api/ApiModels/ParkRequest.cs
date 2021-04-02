using ParkCostCalc.Core.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace ParkCostCalc.Api.ApiModels
{
    public class ParkRequest
    {

        [Required]
        [Display(Name = "Parking Lot")]
        public ParkTypeEnum? ParkType { get; set; }


        [Required(ErrorMessage = "Entry date is required.")]
        [Display(Name = "Entry Date")]
        public DateTime? EntryDate { get; set; }


        [Required(ErrorMessage = "Exit date is required.")]
        [Display(Name = "Exit Date")]
        public DateTime? ExitDate { get; set; }

    }
}
