using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Data.Models.Mapping;
using Domain;

namespace Data.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public partial class cgadbContext : DbContext
    {
        static cgadbContext()
        {
            Database.SetInitializer<cgadbContext>(null);
        }

        public cgadbContext()
            : base("Name=cgadbContext")
        {
        }

        public DbSet<assure> assures { get; set; }
        public DbSet<claim> claims { get; set; }
        public DbSet<complaint> complaints { get; set; }
        public DbSet<contract> contracts { get; set; }
        public DbSet<Event> events { get; set; }
        public DbSet<insurancecompany> insurancecompanies { get; set; }
        public DbSet<insuranecpolicy> insuranecpolicies { get; set; }
        public DbSet<post> posts { get; set; }
        public DbSet<subject> subjects { get; set; }
        public DbSet<tow> tows { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<user_event> user_event { get; set; }
        public DbSet<vehicule> vehicules { get; set; }
        public DbSet<vehicule_claim> vehicule_claim { get; set; }
        public DbSet<rendez_vous> rebndez_vous { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new assureMap());
            modelBuilder.Configurations.Add(new claimMap());
            modelBuilder.Configurations.Add(new complaintMap());
            modelBuilder.Configurations.Add(new contractMap());
            modelBuilder.Configurations.Add(new eventMap());
            modelBuilder.Configurations.Add(new insurancecompanyMap());
            modelBuilder.Configurations.Add(new insuranecpolicyMap());
            modelBuilder.Configurations.Add(new postMap());
            modelBuilder.Configurations.Add(new subjectMap());
            modelBuilder.Configurations.Add(new towMap());
            modelBuilder.Configurations.Add(new userMap());
            modelBuilder.Configurations.Add(new user_eventMap());
            modelBuilder.Configurations.Add(new vehiculeMap());
            modelBuilder.Configurations.Add(new vehicule_claimMap());
            modelBuilder.Configurations.Add(new rendezVousMap());

        }
    }
}
