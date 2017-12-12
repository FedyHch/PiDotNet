using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class user_eventMap : EntityTypeConfiguration<user_event>
    {
        public user_eventMap()
        {
            // Primary Key
            this.HasKey(t => new { t.lstInsured_Cin, t.listEvent_EventId });

            // Properties
            this.Property(t => t.lstInsured_Cin)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.listEvent_EventId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("user_event", "cgadb");
            this.Property(t => t.lstInsured_Cin).HasColumnName("lstInsured_Cin");
            this.Property(t => t.listEvent_EventId).HasColumnName("listEvent_EventId");
        }
    }
}
