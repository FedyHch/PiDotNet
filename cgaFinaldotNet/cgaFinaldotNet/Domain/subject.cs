using System;
using System.Collections.Generic;


namespace Data.Models
{
    public partial class subject
    {
        public int SubjectId { get; set; }
        public string SubjectContents { get; set; }
        public Nullable<System.DateTime> SubjectDate { get; set; }
        public string SubjectTitle { get; set; }
        public string insured_Cin { get; set; }
        
        public virtual ICollection<post> listPost { get; set; }
    }
}
