using Library2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Library2.DAL
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(): base("name=LibraryContext")
        {

        }
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<User> Users { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    Database.SetInitializer<LibraryContext>(new DropCreateDatabaseIfModelChanges<LibraryContext>());
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}