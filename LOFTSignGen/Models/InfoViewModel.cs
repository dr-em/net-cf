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
        [Display(Name = "Contact Number")]
        public string Contact { get; set; }

        [Display(Name = "LinkedIn Id")]
        public string LinkedInId { get; set; }
    }
}