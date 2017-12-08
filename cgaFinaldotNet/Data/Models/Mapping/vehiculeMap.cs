using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class vehiculeMap : EntityTypeConfiguration<vehicule>
    {
        public vehiculeMap()
        {
            // Primary Key
            this.HasKey(t => t.chasisNumber);

            // Properties
            this.Property(t => t.chasisNumber)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Marque)
                .HasMaxLength(255);

            this.Property(t => t.model)
                .HasMaxLength(255);

            this.Property(t => t.registrationNumber)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("vehicule", "cgadb");
            this.Property(t => t.chasisNumber).HasColumnName("chasisNumber");
            this.Property(t => t.Marque).HasColumnName("Marque");
            this.Property(t => t.model).HasColumnName("model");
            this.Property(t => t.power).HasColumnName("power");
            this.Property(t => t.registrationNumber).HasColumnName("registrationNumber");
            this.Property(t => t.contractVehicule_ContractId).HasColumnName("contractVehicule_ContractId");
        }
    }
}
