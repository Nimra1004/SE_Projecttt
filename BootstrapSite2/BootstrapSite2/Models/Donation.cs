//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BootstrapSite2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Donation
    {
        public int DonationsID { get; set; }
        public System.DateTime Donatdate { get; set; }
        public string Place { get; set; }
        public int FK_Donation_ID { get; set; }
    
        public virtual Donor Donor { get; set; }
    }
}