using Library2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library2.DAL
{
    public class BookRepository
    {
        public LibraryContext db = new LibraryContext();

        void add(Book u)
        {
            db.Books.Add(u);
            db.SaveChanges();
        }

        public void Remove(Guid id)
        {
            var toRemove = db.Books.SingleOrDefault(item => item.BookID == id);
            db.Books.Remove(toRemove);
            db.SaveChanges();
        }

        public List<Book> GetAll()
        {
            return db.Books.ToList();
        }

        public Book Get(Guid id)
        {
            return db.Books.SingleOrDefault(item => item.BookID == id);
        }
        //jak to działa?
        public void Edit(Book p)
        {
            db.Entry(p).State = System.Data.Entity.EntityState.Modified;
        }
    }
}