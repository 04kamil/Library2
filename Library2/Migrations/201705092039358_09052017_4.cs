namespace Library2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _09052017_4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "ReleasedDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "ReleasedDate", c => c.DateTime(nullable: false));
        }
    }
}
