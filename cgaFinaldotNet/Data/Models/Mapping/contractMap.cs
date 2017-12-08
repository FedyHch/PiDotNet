using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class contractMap : EntityTypeConfiguration<contract>
    {
        public contractMap()
        {
            // Primary Key
            this.HasKey(t => t.ContractId);

            // Properties
            this.Property(t => t.Type)
                .HasMaxLength(255);

            this.Property(t => t.insuraceAgentContract_Cin)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("contract", "cgadb");
            this.Property(t => t.ContractId).HasColumnName("ContractId");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.assures_id).HasColumnName("assures_id");
            this.Property(t => t.insuraceAgentContract_Cin).HasColumnName("insuraceAgentContract_Cin");
            this.Property(t => t.insuranceCompany_CompId).HasColumnName("insuranceCompany_CompId");
            this.Property(t => t.insurancePolicy_id).HasColumnName("insurancePolicy_id");
        }
    }
}
