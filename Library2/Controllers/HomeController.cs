using Library2.DAL;
using Library2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            LibraryContext db = new LibraryContext();
            //Author a = new Author()
            //{
            //    AuthorID = Guid.NewGuid(),
            //    Name = "Jan Kowalski",
            //    Descryption = "Jakiś opis",
            //    Life = "1800-1840"
            //};
            //db.Author.Add(a);
            //db.SaveChanges();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}