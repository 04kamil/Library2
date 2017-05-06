using Library2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library2.DAL
{
    public class AuthorRepository
    {
        LibraryContext db = new LibraryContext();

        public void Add(Author a)
        {
            db.Author.Add(a);
            db.SaveChanges();
        }

        public void Remove(Guid id)
        {
            var toRemove = db.Author.SingleOrDefault(item => item.AuthorID == id);
            db.Author.Remove(toRemove);
            db.SaveChanges();
        }

        public void Update (Guid id, string _name,string _descryption,string _life)
        {
            var toEdit = db.Author.SingleOrDefault(item => item.AuthorID == id);

            if(_name != null)
            {
                toEdit.Name = _name;
            }
            if(_descryption != null)
            {
                toEdit.Descryption = _descryption;
            }
            if(_life!=null)
            {
                toEdit.Life = _life;
            }

            db.SaveChanges();
        }
        public List<Author>getAll()
        {
            return db.Author.ToList();
        }

        public Author Get(Guid id)
        {

            return db.Author.SingleOrDefault(item => item.AuthorID == id);
        }


    }
}