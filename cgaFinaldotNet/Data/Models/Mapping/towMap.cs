using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class towMap : EntityTypeConfiguration<tow>
    {
        public towMap()
        {
            // Primary Key
            this.HasKey(t => t.tow_id);

            // Properties
            this.Property(t => t.zone)
                .HasMaxLength(255);

            this.Property(t => t.insuranceAgent_Cin)
                .HasMaxLength(255);

            this.Property(t => t.insured_Cin)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("tow", "cgadb");
            this.Property(t => t.tow_id).HasColumnName("tow_id");
            this.Property(t => t.date_tow).HasColumnName("date_tow");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.zone).HasColumnName("zone");
            this.Property(t => t.insuranceAgent_Cin).HasColumnName("insuranceAgent_Cin");
            this.Property(t => t.insured_Cin).HasColumnName("insured_Cin");
        }
    }
}
