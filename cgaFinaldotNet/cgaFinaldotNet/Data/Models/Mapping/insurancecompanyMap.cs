using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class insurancecompanyMap : EntityTypeConfiguration<insurancecompany>
    {
        public insurancecompanyMap()
        {
            // Primary Key
            this.HasKey(t => t.CompId);

            // Properties
            this.Property(t => t.Address)
                .HasMaxLength(255);

            this.Property(t => t.CompName)
                .HasMaxLength(255);

            this.Property(t => t.Fax)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("insurancecompany", "cgadb");
            this.Property(t => t.CompId).HasColumnName("CompId");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.CompName).HasColumnName("CompName");
            this.Property(t => t.Fax).HasColumnName("Fax");
        }
    }
}
