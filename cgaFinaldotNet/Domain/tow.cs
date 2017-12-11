using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class tow
    {


        public tow()
        {
            
        }

        public tow(DateTime? date_tow, bool status, int tow_id, string zone)
        {
            this.date_tow = date_tow;
            this.status = status;
            this.tow_id = tow_id;
            this.zone = zone;
        }

        public int tow_id { get; set; }
        public Nullable<System.DateTime> date_tow { get; set; }
        public bool status { get; set; }
        public string zone { get; set; }
        public string insuranceAgent_Cin { get; set; }
        public string insured_Cin { get; set; }
    }
}
