namespace ContinuousMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    name = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.id);

        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
