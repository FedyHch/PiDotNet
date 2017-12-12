using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class vehicule_claimMap : EntityTypeConfiguration<vehicule_claim>
    {
        public vehicule_claimMap()
        {
            // Primary Key
            this.HasKey(t => new { t.listVehicule_chasisNumber, t.listClaim_ClaimId });

            // Properties
            this.Property(t => t.listVehicule_chasisNumber)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.listClaim_ClaimId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vehicule_claim", "cgadb");
            this.Property(t => t.listVehicule_chasisNumber).HasColumnName("listVehicule_chasisNumber");
            this.Property(t => t.listClaim_ClaimId).HasColumnName("listClaim_ClaimId");
        }
    }
}
