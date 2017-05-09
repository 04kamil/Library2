using Library2.DAL;
using Library2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library2.Controllers
{
    public class CatalogController : Controller
    {
        BookRepository br = new BookRepository();

        // GET: Catalog
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult DodajKsiazke()
        {
            
            return View();
                
        }

        [HttpPost]
        public ActionResult DodajKsiazkeDoBazy(Book b)
        {
            br.add(b);
            return View("DodajKsiazke");

        }
        public ActionResult DodajAutora()
        {
            return View("DodajKsiazke");
        }

        public ActionResult Wyswietl()
        {

            return View(br.GetAll());
        }
    }
}