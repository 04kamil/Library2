namespace Library2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class smallChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Loans", "Retured", c => c.Boolean(nullable: false));
            DropColumn("dbo.Loans", "ReturnOnTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Loans", "ReturnOnTime", c => c.Boolean(nullable: false));
            DropColumn("dbo.Loans", "Retured");
        }
    }
}
