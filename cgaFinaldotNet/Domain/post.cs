using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class post
    {
        public int PostId { get; set; }
        public string PostContents { get; set; }
        public Nullable<System.DateTime> PostDate { get; set; }
        public Nullable<int> subject_SubjectId { get; set; }
    }
}
