namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "cgadb.assure",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        email = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        nom = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        password = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        pointFidel = c.Int(nullable: false),
                        prenom = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "cgadb.claim",
                c => new
                    {
                        ClaimId = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        IncidentDate = c.DateTime(precision: 0),
                        IncidentPlace = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        Picture = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        expertClaim_Cin = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        insuranceAgent_Cin = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        insuredClaim_Cin = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ClaimId);
            
            CreateTable(
                "cgadb.complaint",
                c => new
                    {
                        Complaint_id = c.Int(nullable: false, identity: true),
                        Complaint_date = c.DateTime(precision: 0),
                        description = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        response = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        claim_ClaimId = c.Int(),
                        insuredComplaint_Cin = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Complaint_id);
            
            CreateTable(
                "cgadb.contract",
                c => new
                    {
                        ContractId = c.Int(nullable: false, identity: true),
                        EndDate = c.DateTime(precision: 0),
                        StartDate = c.DateTime(precision: 0),
                        Type = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        assures_id = c.Int(),
                        insuraceAgentContract_Cin = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        insuranceCompany_CompId = c.Int(),
                        insurancePolicy_id = c.Int(),
                    })
                .PrimaryKey(t => t.ContractId);
            
            CreateTable(
                "cgadb.event",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        EventDate = c.DateTime(precision: 0),
                        EventDescription = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        EventPlace = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        EventTheme = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        EventTitle = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        agentEvent_Cin = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        agentEvent = c.Binary(),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "cgadb.insurancecompany",
                c => new
                    {
                        CompId = c.Int(nullable: false, identity: true),
                        Address = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        CompName = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        Fax = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.CompId);
            
            CreateTable(
                "cgadb.insuranecpolicy",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        InsuranceClass = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "cgadb.post",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        PostContents = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        PostDate = c.DateTime(precision: 0),
                        subject_SubjectId = c.Int(),
                    })
                .PrimaryKey(t => t.PostId);
            
            CreateTable(
                "cgadb.subject",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        SubjectContents = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        SubjectDate = c.DateTime(precision: 0),
                        SubjectTitle = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        insured_Cin = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.SubjectId);
            
            CreateTable(
                "cgadb.tow",
                c => new
                    {
                        tow_id = c.Int(nullable: false, identity: true),
                        date_tow = c.DateTime(precision: 0),
                        status = c.Boolean(nullable: false),
                        zone = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        insuranceAgent_Cin = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        insured_Cin = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.tow_id);
            
            CreateTable(
                "cgadb.user_event",
                c => new
                    {
                        lstInsured_Cin = c.String(nullable: false, maxLength: 255, unicode: false, storeType: "nvarchar"),
                        listEvent_EventId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.lstInsured_Cin, t.listEvent_EventId });
            
            CreateTable(
                "cgadb.user",
                c => new
                    {
                        Cin = c.String(nullable: false, maxLength: 255, unicode: false, storeType: "nvarchar"),
                        DTYPE = c.String(nullable: false, maxLength: 31, unicode: false, storeType: "nvarchar"),
                        Birth_date = c.DateTime(precision: 0),
                        E_mail = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        First_name = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        Last_name = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        Phone_number = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        login = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        password = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        driving_licence_id = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        role = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        salary = c.Single(),
                        status = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        Diplome = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Cin);
            
            CreateTable(
                "cgadb.vehicule_claim",
                c => new
                    {
                        listVehicule_chasisNumber = c.String(nullable: false, maxLength: 255, unicode: false, storeType: "nvarchar"),
                        listClaim_ClaimId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.listVehicule_chasisNumber, t.listClaim_ClaimId });
            
            CreateTable(
                "cgadb.vehicule",
                c => new
                    {
                        chasisNumber = c.String(nullable: false, maxLength: 255, unicode: false, storeType: "nvarchar"),
                        Marque = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        model = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        power = c.Int(nullable: false),
                        registrationNumber = c.String(maxLength: 255, unicode: false, storeType: "nvarchar"),
                        contractVehicule_ContractId = c.Int(),
                    })
                .PrimaryKey(t => t.chasisNumber);
            
        }
        
        public override void Down()
        {
            DropTable("cgadb.vehicule");
            DropTable("cgadb.vehicule_claim");
            DropTable("cgadb.user");
            DropTable("cgadb.user_event");
            DropTable("cgadb.tow");
            DropTable("cgadb.subject");
            DropTable("cgadb.post");
            DropTable("cgadb.insuranecpolicy");
            DropTable("cgadb.insurancecompany");
            DropTable("cgadb.event");
            DropTable("cgadb.contract");
            DropTable("cgadb.complaint");
            DropTable("cgadb.claim");
            DropTable("cgadb.assure");
        }
    }
}
