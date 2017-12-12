using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class assureMap : EntityTypeConfiguration<assure>
    {
        public assureMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.email)
                .HasMaxLength(255);

            this.Property(t => t.nom)
                .HasMaxLength(255);

            this.Property(t => t.password)
                .HasMaxLength(255);

            this.Property(t => t.prenom)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("assure", "cgadb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.nom).HasColumnName("nom");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.pointFidel).HasColumnName("pointFidel");
            this.Property(t => t.prenom).HasColumnName("prenom");
        }
    }
}
