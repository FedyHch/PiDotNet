using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class complaintMap : EntityTypeConfiguration<complaint>
    {
        public complaintMap()
        {
            // Primary Key
            this.HasKey(t => t.Complaint_id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.response)
                .HasMaxLength(255);

            this.Property(t => t.insuredComplaint_Cin)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("complaint", "cgadb");
            this.Property(t => t.Complaint_id).HasColumnName("Complaint_id");
            this.Property(t => t.Complaint_date).HasColumnName("Complaint_date");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.response).HasColumnName("response");
            this.Property(t => t.claim_ClaimId).HasColumnName("claim_ClaimId");
            this.Property(t => t.insuredComplaint_Cin).HasColumnName("insuredComplaint_Cin");
        }
    }
}
