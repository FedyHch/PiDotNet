using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class postMap : EntityTypeConfiguration<post>
    {
        public postMap()
        {
            // Primary Key
            this.HasKey(t => t.PostId);

            // Properties
            this.Property(t => t.PostContents)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("post", "cgadb");
            this.Property(t => t.PostId).HasColumnName("PostId");
            this.Property(t => t.PostContents).HasColumnName("PostContents");
            this.Property(t => t.PostDate).HasColumnName("PostDate");
            this.Property(t => t.subject_SubjectId).HasColumnName("subject_SubjectId");
        }
    }
}
