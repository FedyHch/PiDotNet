using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class eventMap : EntityTypeConfiguration<Event>
    {
        public eventMap()
        {
            // Primary Key
            this.HasKey(t => t.EventId);

            // Properties
            this.Property(t => t.EventDescription)
                .HasMaxLength(255);

            this.Property(t => t.EventPlace)
                .HasMaxLength(255);

            this.Property(t => t.EventTheme)
                .HasMaxLength(255);

            this.Property(t => t.EventTitle)
                .HasMaxLength(255);

            this.Property(t => t.agentEvent_Cin)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("event", "cgadb");
            this.Property(t => t.EventId).HasColumnName("EventId");
            this.Property(t => t.EventDate).HasColumnName("EventDate");
            this.Property(t => t.EventDescription).HasColumnName("EventDescription");
            this.Property(t => t.EventPlace).HasColumnName("EventPlace");
            this.Property(t => t.EventTheme).HasColumnName("EventTheme");
            this.Property(t => t.EventTitle).HasColumnName("EventTitle");
            this.Property(t => t.agentEvent_Cin).HasColumnName("agentEvent_Cin");
            this.Property(t => t.agentEvent).HasColumnName("agentEvent");
        }
    }
}
