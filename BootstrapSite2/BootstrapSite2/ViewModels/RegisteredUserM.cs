using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BootstrapSite2.ViewModels
{
    public class RegisteredUserM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RegisteredUserM()
        {
            this.Donors = new HashSet<DonorM>();
        }
        public int R_ID { get; set; }

        [Required, EmailAddress]
        [Display(Name = "Email")]
        public string R_Email { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string R_Name { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string R_Gender { get; set; }

        [Required]
        [Display(Name = "BloodGroup")]
        public string R_BloodGroup { get; set; }

        [Required]
        [Display(Name = "Contact")]
        public string R_Contact { get; set; }

        [Required]
        [Display(Name = "DateOfBirth")]
        public System.DateTime R_Dateofbirth { get; set; }

        [Required]
        [Display(Name = "City")]
        public string R_City { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string R_Address { get; set; }

        public System.DateTime R_AddedOn { get; set; }

        [DataType(DataType.Password), Required]
        [Display(Name = "Password")]
        public string R_Password { get; set; }

        [Required, System.ComponentModel.DataAnnotations.Compare("R_Password")]
        [Display(Name = "ConfirmPassword")]
        public string R_ConfirmPassword { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonorM> Donors { get; set; }
        public static IEnumerable<SelectListItem> GetGenderList()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new  SelectListItem{Text = "Male", Value = "Male" },
                new  SelectListItem{Text = "Female", Value = "Female" },
            };
            return items;
        }
        public static IEnumerable<SelectListItem> BloodGroupList()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new  SelectListItem{Text = "A+", Value = "A+" },
                new  SelectListItem{Text = "A-", Value = "A-" },
                new  SelectListItem{Text = "B+", Value = "B+" },
                new  SelectListItem{Text = "B-", Value = "B-" },
                new  SelectListItem{Text = "AB+", Value = "AB+" },
                new  SelectListItem{Text = "AB-", Value = "AB-" },
                new  SelectListItem{Text = "O+", Value = "O+" },
                new  SelectListItem{Text = "O-", Value = "O-" },
            };
            return items;
        }
    }
}
