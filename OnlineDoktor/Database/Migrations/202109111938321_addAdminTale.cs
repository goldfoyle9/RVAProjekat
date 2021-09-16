namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAdminTale : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
