using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Event
    {
        public int EventId { get; set; }
        public Nullable<System.DateTime> EventDate { get; set; }
        public string EventDescription { get; set; }
        public string EventPlace { get; set; }
        public string EventTheme { get; set; }
        public string EventTitle { get; set; }
        public string agentEvent_Cin { get; set; }
        public byte[] agentEvent { get; set; }
    }
}
