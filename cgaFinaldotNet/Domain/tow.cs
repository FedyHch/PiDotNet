using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class tow
    {
        public int tow_id { get; set; }
        public Nullable<System.DateTime> date_tow { get; set; }
        public bool status { get; set; }
        public string zone { get; set; }
        public string insuranceAgent_Cin { get; set; }
        public string insured_Cin { get; set; }
    }
}
