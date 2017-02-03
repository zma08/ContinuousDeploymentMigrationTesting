namespace ContinuousMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newAttrAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "major", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "major");
        }
    }
}
