using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class claimMap : EntityTypeConfiguration<claim>
    {
        public claimMap()
        {
            // Primary Key
            this.HasKey(t => t.ClaimId);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(255);

            this.Property(t => t.IncidentPlace)
                .HasMaxLength(255);

            this.Property(t => t.Picture)
                .HasMaxLength(255);

            this.Property(t => t.expertClaim_Cin)
                .HasMaxLength(255);

            this.Property(t => t.insuranceAgent_Cin)
                .HasMaxLength(255);

            this.Property(t => t.insuredClaim_Cin)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("claim", "cgadb");
            this.Property(t => t.ClaimId).HasColumnName("ClaimId");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.IncidentDate).HasColumnName("IncidentDate");
            this.Property(t => t.IncidentPlace).HasColumnName("IncidentPlace");
            this.Property(t => t.Picture).HasColumnName("Picture");
            this.Property(t => t.expertClaim_Cin).HasColumnName("expertClaim_Cin");
            this.Property(t => t.insuranceAgent_Cin).HasColumnName("insuranceAgent_Cin");
            this.Property(t => t.insuredClaim_Cin).HasColumnName("insuredClaim_Cin");
        }
    }
}
