using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class claim
    {
        public int ClaimId { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> IncidentDate { get; set; }
        public string IncidentPlace { get; set; }
        public string Picture { get; set; }
        public string expertClaim_Cin { get; set; }
        public string insuranceAgent_Cin { get; set; }
        public string insuredClaim_Cin { get; set; }
    }
}
