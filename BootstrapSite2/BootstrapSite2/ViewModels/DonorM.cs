using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrapSite2.ViewModels
{
    public class DonorM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonorM()
        {
            this.Donations = new HashSet<DonationM>();
        }

        public int D_ID { get; set; }
        public Nullable<int> D_NoDonations { get; set; }
        public string D_candonate { get; set; }
        public int FK_donor_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonationM> Donations { get; set; }
        public virtual RegisteredUserM RegisteredUser { get; set; }
    }
}