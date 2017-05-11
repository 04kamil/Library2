namespace Library2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        AuthorID = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Life = c.String(),
                        Descryption = c.String(),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        BookID = c.Guid(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Autor = c.String(),
                        Publisher = c.String(),
                        ReleasedDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Pages = c.Int(nullable: false),
                        Description = c.String(),
                        ISBN = c.String(),
                        Language = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.BookID);
            
            CreateTable(
                "dbo.Loan",
                c => new
                    {
                        LoanID = c.Guid(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Retured = c.Boolean(nullable: false),
                        book_BookID = c.Guid(),
                        user_UserID = c.Guid(),
                    })
                .PrimaryKey(t => t.LoanID)
                .ForeignKey("dbo.Book", t => t.book_BookID)
                .ForeignKey("dbo.User", t => t.user_UserID)
                .Index(t => t.book_BookID)
                .Index(t => t.user_UserID);
            
            CreateTable(
                "dbo.User",
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
            DropForeignKey("dbo.Loan", "user_UserID", "dbo.User");
            DropForeignKey("dbo.Loan", "book_BookID", "dbo.Book");
            DropIndex("dbo.Loan", new[] { "user_UserID" });
            DropIndex("dbo.Loan", new[] { "book_BookID" });
            DropTable("dbo.User");
            DropTable("dbo.Loan");
            DropTable("dbo.Book");
            DropTable("dbo.Author");
        }
    }
}
