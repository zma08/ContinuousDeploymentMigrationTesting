namespace ContinuousMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addASecondShcema : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "hobby", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "hobby");
        }
    }
}
