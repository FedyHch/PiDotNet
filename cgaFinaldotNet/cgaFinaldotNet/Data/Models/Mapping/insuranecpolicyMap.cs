using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class insuranecpolicyMap : EntityTypeConfiguration<insuranecpolicy>
    {
        public insuranecpolicyMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.InsuranceClass)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("insuranecpolicy", "cgadb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.InsuranceClass).HasColumnName("InsuranceClass");
        }
    }
}
