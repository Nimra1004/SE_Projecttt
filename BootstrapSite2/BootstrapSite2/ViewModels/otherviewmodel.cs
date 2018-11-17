using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BootstrapSite2.ViewModels
{
    public class otherviewmodel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }


        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Blood Group")]
        public string Blood_group { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        public Nullable<System.DateTime> DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Contact")]
        public string Contact { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        
        [Display(Name = "City")]
        public string city { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string Confirm_Password { get; set; }
    }
}