using Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class rendezVousMap : EntityTypeConfiguration<rendez_vous>
    {
        public rendezVousMap()
        {
            // Primary Key
            this.HasKey(t => t.RendezVousId);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(255);

            this.Property(t => t.NomAssurance)
                .HasMaxLength(255);

            this.Property(t => t.DateRendezVous);            
            

            // Table & Column Mappings
            this.ToTable("rendezvous", "cgadb");
            this.Property(t => t.RendezVousId).HasColumnName("RendezVousId");
            this.Property(t => t.DateRendezVous).HasColumnName("DateRendezVous");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.NomAssurance).HasColumnName("NomAssurance");
            this.Property(t => t.Insured_cin).HasColumnName("Insured_cin");
        }
    }
}
