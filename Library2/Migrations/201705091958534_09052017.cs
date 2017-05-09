namespace Library2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _09052017 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "author_AuthorID", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "author_AuthorID" });
            AddColumn("dbo.Books", "Autor", c => c.String());
            DropColumn("dbo.Books", "author_AuthorID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "author_AuthorID", c => c.Guid());
            DropColumn("dbo.Books", "Autor");
            CreateIndex("dbo.Books", "author_AuthorID");
            AddForeignKey("dbo.Books", "author_AuthorID", "dbo.Authors", "AuthorID");
        }
    }
}
