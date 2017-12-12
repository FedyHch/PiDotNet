using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class subjectMap : EntityTypeConfiguration<subject>
    {
        public subjectMap()
        {
            // Primary Key
            this.HasKey(t => t.SubjectId);

            // Properties
            this.Property(t => t.SubjectContents)
                .HasMaxLength(255);

            this.Property(t => t.SubjectTitle)
                .HasMaxLength(255);

            this.Property(t => t.insured_Cin)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("subject", "cgadb");
            this.Property(t => t.SubjectId).HasColumnName("SubjectId");
            this.Property(t => t.SubjectContents).HasColumnName("SubjectContents");
            this.Property(t => t.SubjectDate).HasColumnName("SubjectDate");
            this.Property(t => t.SubjectTitle).HasColumnName("SubjectTitle");
            this.Property(t => t.insured_Cin).HasColumnName("insured_Cin");
        }
    }
}
