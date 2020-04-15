using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParkCostCalc.Web.Models
{
    public class AppUserBindingModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Lösenord")]
        public string Password { get; set; }
        [Display(Name = "Typ")]
        public string Role { get; set; }
    }
}
