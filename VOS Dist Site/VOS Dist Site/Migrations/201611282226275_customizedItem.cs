namespace VOS_Dist_Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customizedItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Items", "nicPercent", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "nicPercent");
            DropColumn("dbo.Items", "quantity");
        }
    }
}
