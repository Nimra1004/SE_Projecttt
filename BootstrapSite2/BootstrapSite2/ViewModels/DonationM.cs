using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrapSite2.ViewModels
{
    public class DonationM
    {
        public int DonationsID { get; set; }
        public System.DateTime Donatdate { get; set; }
        public string Place { get; set; }
        public int FK_Donation_ID { get; set; }

        public virtual DonorM Donor { get; set; }
    }
}