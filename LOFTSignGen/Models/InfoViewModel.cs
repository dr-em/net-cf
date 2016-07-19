using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LOFTSignGen.Models
{
    public class InfoViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Business Title")]
        public string BusinessTitle { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Business Address")]
        public string Address { get; set; }
        [Required]
        [RegularExpression("^[0-9 \\+]*$", ErrorMessage ="Only numbers, spaces and plus sign allowed")]
        [Display(Name = "Office Phone")]
        public string Office { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Six numbers, no spaces allowed")]
        [MaxLength(6, ErrorMessage = "Six numbers, no spaces allowed")]
        [Display(Name = "Internal Extension")]
        public string OfficeExtension { get; set; }

        [RegularExpression("^[0-9 \\+]*$", ErrorMessage = "Only numbers, spaces and plus sign allowed")]
        [Display(Name = "Mobile Phone")]
        public string Mobile { get; set; }
        [RegularExpression("^[a-zA-Z-]+$", ErrorMessage = "Only letters and dashes")]
        [Display(Name = "LinkedIn Id")]
        public string LinkedInId { get; set; }
    }
}