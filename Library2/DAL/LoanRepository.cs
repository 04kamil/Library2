using Library2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library2.DAL
{
    public class LoanRepository
    {
        LibraryContext db = new LibraryContext();

        public void Add(Book b, User u)
        {
            db.Loans.Add(new Loan()
            {
                LoanID = Guid.NewGuid(),
                book = b,
                user = u,
                Retured = false,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(21),
            });
            db.SaveChanges();
        }

        public void ExtendLoan(Guid id, int days)
        {
            var loan = db.Loans.SingleOrDefault(item => item.LoanID == id);
            loan.EndDate.AddDays(days);
            db.SaveChanges();
        }

        public void Returned(Guid id)
        {
            var loan = db.Loans.SingleOrDefault(item => item.LoanID == id);
            loan.Retured = true;
            db.SaveChanges();
        }
    }
}