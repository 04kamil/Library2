using Library2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library2.DAL
{
    public class UserRepository
    {
        LibraryContext db = new LibraryContext();

        void add(User u)
        {
            db.Users.Add(u);
            db.SaveChanges();
        }

        public void Remove(Guid id)
        {
            var toRemove = db.Users.SingleOrDefault(item => item.UserID == id);
            db.Users.Remove(toRemove);
            db.SaveChanges();
        }

        public User Get(Guid id)
        {

            return db.Users.SingleOrDefault(item => item.UserID == id);
        }

        public void BlockUser(Guid id)
        {
            //inny sposob by dostac do elementu (LINQ)
            var customer = (from c in db.Users where c.UserID == id select c).First();
            customer.Active = false;
            db.SaveChanges();
        }
        public void UnblockUser(Guid id)
        {
            //inny sposob by dostac do elementu LINQ
            var customer = (from c in db.Users where c.UserID == id select c).First();
            customer.Active = true;
            db.SaveChanges();
        }



    }
}