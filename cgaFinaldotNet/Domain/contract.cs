using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class contract
    {
        public int ContractId { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public string Type { get; set; }
        public Nullable<int> assures_id { get; set; }
        public string insuraceAgentContract_Cin { get; set; }
        public Nullable<int> insuranceCompany_CompId { get; set; }
        public Nullable<int> insurancePolicy_id { get; set; }
    }
}
