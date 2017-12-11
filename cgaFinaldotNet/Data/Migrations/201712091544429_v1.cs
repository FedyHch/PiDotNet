namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
 
            
            CreateTable(
                "rendezvous",
                c => new
                    {
                        RendezVousId = c.Int(nullable: false, identity: true),
                        DateRendezVous = c.DateTime(nullable: false, precision: 0),
                        Description = c.String(maxLength: 255, storeType: "nvarchar"),
                        NomAssurance = c.String(maxLength: 255, storeType: "nvarchar"),
                        Insured_cin = c.Binary(),
                    })
                .PrimaryKey(t => t.RendezVousId);
            
  
            
        }
        
        public override void Down()
        {
            
            DropTable("rendezvous");
            
        }
    }
}
