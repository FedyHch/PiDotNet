using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class complaint
    {
        public int Complaint_id { get; set; }
        public Nullable<System.DateTime> Complaint_date { get; set; }
        public string description { get; set; }
        public string response { get; set; }
        public Nullable<int> claim_ClaimId { get; set; }
        public string insuredComplaint_Cin { get; set; }
    }
}
