namespace Library2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Author", newName: "Authors");
            RenameTable(name: "dbo.Book", newName: "Books");
            RenameTable(name: "dbo.Loan", newName: "Loans");
            RenameTable(name: "dbo.User", newName: "Users");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Users", newName: "User");
            RenameTable(name: "dbo.Loans", newName: "Loan");
            RenameTable(name: "dbo.Books", newName: "Book");
            RenameTable(name: "dbo.Authors", newName: "Author");
        }
    }
}
