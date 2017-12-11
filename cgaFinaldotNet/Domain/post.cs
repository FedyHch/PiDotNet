using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public partial class post
    {
     
        public int PostId { get; set; }
        public string PostContents { get; set; }
        public Nullable<System.DateTime> PostDate { get; set; }
        [ForeignKey("subjectPost")]
        public Nullable<int> subject_SubjectId { get; set; }

        public subject subjectPost { get; set; }

    }
}
