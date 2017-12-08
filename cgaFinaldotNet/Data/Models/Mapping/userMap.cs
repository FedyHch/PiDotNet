using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class userMap : EntityTypeConfiguration<user>
    {
        public userMap()
        {
            // Primary Key
            this.HasKey(t => t.Cin);

            // Properties
            this.Property(t => t.DTYPE)
                .IsRequired()
                .HasMaxLength(31);

            this.Property(t => t.Cin)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.E_mail)
                .HasMaxLength(255);

            this.Property(t => t.First_name)
                .HasMaxLength(255);

            this.Property(t => t.Last_name)
                .HasMaxLength(255);

            this.Property(t => t.Phone_number)
                .HasMaxLength(255);

            this.Property(t => t.login)
                .HasMaxLength(255);

            this.Property(t => t.password)
                .HasMaxLength(255);

            this.Property(t => t.driving_licence_id)
                .HasMaxLength(255);

            this.Property(t => t.role)
                .HasMaxLength(255);

            this.Property(t => t.status)
                .HasMaxLength(255);

            this.Property(t => t.Diplome)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("user", "cgadb");
            this.Property(t => t.DTYPE).HasColumnName("DTYPE");
            this.Property(t => t.Cin).HasColumnName("Cin");
            this.Property(t => t.Birth_date).HasColumnName("Birth_date");
            this.Property(t => t.E_mail).HasColumnName("E_mail");
            this.Property(t => t.First_name).HasColumnName("First_name");
            this.Property(t => t.Last_name).HasColumnName("Last_name");
            this.Property(t => t.Phone_number).HasColumnName("Phone_number");
            this.Property(t => t.login).HasColumnName("login");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.driving_licence_id).HasColumnName("driving_licence_id");
            this.Property(t => t.role).HasColumnName("role");
            this.Property(t => t.salary).HasColumnName("salary");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.Diplome).HasColumnName("Diplome");
        }
    }
}
