namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        LicenseID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        LastName = c.String(),
                        FieldOfWork = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LicenseID);
            
            CreateTable(
                "dbo.Examinations",
                c => new
                    {
                        ExaminationID = c.String(nullable: false, maxLength: 128),
                        ExaminationDate = c.DateTime(nullable: false),
                        ExaminationTime = c.DateTime(nullable: false),
                        ExaminationDoctor_LicenseID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ExaminationID)
                .ForeignKey("dbo.Doctors", t => t.ExaminationDoctor_LicenseID)
                .Index(t => t.ExaminationDoctor_LicenseID);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        SocialSecurityNumber = c.Int(nullable: false),
                        Name = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Examinations", "ExaminationDoctor_LicenseID", "dbo.Doctors");
            DropIndex("dbo.Examinations", new[] { "ExaminationDoctor_LicenseID" });
            DropTable("dbo.Patients");
            DropTable("dbo.Examinations");
            DropTable("dbo.Doctors");
        }
    }
}
