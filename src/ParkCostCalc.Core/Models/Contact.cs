using System;
using System.ComponentModel.DataAnnotations;

namespace ParkCostCalc.Core.Models
{
    public class Contact
    {

        [Key]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter Your Name")]
        [StringLength(50, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter Your Email")]
        [StringLength(50, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter Subject")]
        [StringLength(50, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter Your Messages")]
        [StringLength(8000, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]
        [Display(Name = "Message")]
        public string Message { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.Now;


    }
}
