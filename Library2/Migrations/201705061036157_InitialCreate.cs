namespace Library2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Life = c.String(),
                        Descryption = c.String(),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Guid(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Publisher = c.String(),
                        ReleasedDate = c.DateTime(nullable: false),
                        Pages = c.Int(nullable: false),
                        Description = c.String(),
                        ISBN = c.String(),
                        Language = c.String(),
                        Image = c.String(),
                        author_AuthorID = c.Guid(),
                    })
                .PrimaryKey(t => t.BookID)
                .ForeignKey("dbo.Authors", t => t.author_AuthorID)
                .Index(t => t.author_AuthorID);
            
            CreateTable(
                "dbo.Loans",
                c => new
                    {
                        LoanID = c.Guid(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        book_BookID = c.Guid(),
                        user_UserID = c.Guid(),
                    })
                .PrimaryKey(t => t.LoanID)
                .ForeignKey("dbo.Books", t => t.book_BookID)
                .ForeignKey("dbo.Users", t => t.user_UserID)
                .Index(t => t.book_BookID)
                .Index(t => t.user_UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Guid(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                        Active = c.Boolean(nullable: false),
                        AccountType = c.Int(nullable: false),
                        Email = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Loans", "user_UserID", "dbo.Users");
            DropForeignKey("dbo.Loans", "book_BookID", "dbo.Books");
            DropForeignKey("dbo.Books", "author_AuthorID", "dbo.Authors");
            DropIndex("dbo.Loans", new[] { "user_UserID" });
            DropIndex("dbo.Loans", new[] { "book_BookID" });
            DropIndex("dbo.Books", new[] { "author_AuthorID" });
            DropTable("dbo.Users");
            DropTable("dbo.Loans");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
